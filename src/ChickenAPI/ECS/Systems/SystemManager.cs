using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog.Fluent;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Utils;

namespace ChickenAPI.ECS.Systems
{
    public class SystemManager
    {
        protected static readonly Logger Log = Logger.GetLogger<EntityManagerBase>();

        private Dictionary<Type, ISystem> _updateSystems = new Dictionary<Type, ISystem>();
        private Dictionary<Type, INotifiableSystem> _notifiableSystems = new Dictionary<Type, INotifiableSystem>();

        public void RegisterSystem<TSystem>(TSystem system)
            where TSystem : ISystem
        {
            if (_updateSystems.FirstOrDefault(x => x.Key == typeof(TSystem)).Value != null)
            {
                return;
            }
            
            _updateSystems.Add(typeof(TSystem), system);
        }

        public void RegisterNotifiableSystem<TSystem>(TSystem system)
            where TSystem : INotifiableSystem
        {
            if (_updateSystems.FirstOrDefault(x => x.Key == typeof(TSystem)).Value != null)
            {
                return;
            }
            
            _notifiableSystems.Add(typeof(TSystem), system);
        }

        public void UnregisterSystem<TSystem>()
        {
            var updateSystem = _updateSystems.First(x => x is TSystem);

            if (updateSystem.Value != null)
            {
                _updateSystems.Remove(updateSystem.Key);
            }
        }

        public void UnregisterNotifiableSystem<TSystem>()
        {
            var notifiablesystem = _notifiableSystems.First(x => x is TSystem);

            if (notifiablesystem.Value != null)
            {
                _notifiableSystems.Remove(notifiablesystem.Key);
            }
        }

        public void NotifySystem<T>(IEntity entity, SystemEventArgs e) where T : class, INotifiableSystem
        {
            try
            {
                _notifiableSystems[typeof(T)].Execute(entity, e);
            }
            catch (Exception exception)
            {
                Log.Error("[NOTIFY_SYSTEM]", exception);
                Console.WriteLine(exception);
                throw;
            }
        }

        public void Update()
        {
            foreach (var system in _updateSystems)
            {
                system.Value.Update(DateTime.Now.Millisecond);
            }
        }
    }
}
