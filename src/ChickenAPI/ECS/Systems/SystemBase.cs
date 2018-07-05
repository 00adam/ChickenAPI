using System;
using System.Linq.Expressions;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.ECS.Systems
{
    public abstract class SystemBase : ISystem
    {
        private Func<IEntity, bool> _filter;

        /// <summary>
        /// The delay in ms required for each Update call
        /// </summary>
        protected double _delay { get; }

        protected double _lastTick { get; private set; }

        public IEntityManager EntityManager { get; }

        public bool IsActive { get; private set; }

        /// <summary>
        /// The delay is in ms 
        /// </summary>
        /// <param name="entityManager"></param>
        /// <param name="delay"></param>
        protected SystemBase(IEntityManager entityManager, long delay = 0)
        {
            _delay = delay;
            _lastTick = DateTime.Now.Millisecond;
            EntityManager = entityManager;
            IsActive = true;
        }

        public void Activate()
        {
            if (IsActive)
            {
                throw new Exception("System is already activated");
            }
            IsActive = true;
        }

        public void Deactivate()
        {
            if (!IsActive)
            {
                throw new Exception("System is already deactivated");
            }

            IsActive = false;
        }


        /// <summary>
        ///     Gets filter of the system.
        /// </summary>
        /// <remarks>
        ///     This filter is used to check if the entities needs to be updated by this system.
        /// </remarks>
        protected virtual Expression<Func<IEntity, bool>> Filter { get; }

        public void Update(double tick)
        {
            if (tick - _lastTick < _delay)
            {
                return;
            }

            _lastTick = tick;
            Execute();
        }

        public virtual void Execute()
        {
            throw new NotImplementedException();
        }

        public virtual void Execute(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Match(IEntity entity)
        {
            _filter = _filter ?? Filter.Compile();

            return (bool)_filter?.Invoke(entity);
        }
    }
}