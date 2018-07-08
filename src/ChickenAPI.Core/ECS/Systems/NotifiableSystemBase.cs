using System;
using ChickenAPI.Core.ECS.Entities;

namespace ChickenAPI.Core.ECS.Systems
{
    public abstract class NotifiableSystemBase : SystemBase, INotifiableSystem
    {
        protected NotifiableSystemBase(IEntityManager entityManager) : base(entityManager)
        {
        }

        public virtual void Execute(IEntity entity, SystemEventArgs e)
        {
            // no base implementation yet
            throw new NotImplementedException();
        }
    }
}