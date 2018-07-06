using ChickenAPI.Core.DAL.TransferObjects;

namespace ChickenAPI.Core.DAL.AccessLayer.Repository
{
    public interface IMappedRepository<T> : ISynchronousRepository<T, long>, IAsyncRepository<T, long> where T : class, IMappedDto
    {
    }
}