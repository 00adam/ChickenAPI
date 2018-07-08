using System;
using ChickenAPI.Core.DAL.TransferObjects;

namespace ChickenAPI.Core.DAL.AccessLayer.Repository
{
    public interface ISynchronizedRepository<T> : ISynchronousRepository<T, Guid>, IAsyncRepository<T, Guid> where T : class, ISynchronizedDto
    {
    }
}