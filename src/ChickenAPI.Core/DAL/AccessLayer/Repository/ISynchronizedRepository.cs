using System;

namespace ChickenAPI.Core.DAL.AccessLayer.Repository
{
    public interface ISynchronizedRepository<T> : ISynchronousRepository<T, Guid>, IAsyncRepository<T, Guid> where T : class, ISynchronizedDto
    {
    }
}