using ChickenAPI.ECS.Entities;

namespace ChickenAPI.ECS.Systems
{
    public interface ISystem
    {
        IEntityManager EntityManager { get; }

        void Update(double tick);

        /// <summary>
        ///     Executes the system logic for the entity passed as parameter.
        /// </summary>
        /// <param name="entity">Entity</param>
        void Execute(IEntity entity);

        void Execute();

        /// <summary>
        ///     Check if the entity matches the system filter predicate.
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns></returns>
        bool Match(IEntity entity);
    }
}