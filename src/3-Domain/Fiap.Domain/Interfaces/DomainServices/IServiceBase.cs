using Fiap.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Fiap.Domain.Interfaces.DomainServices
{
    public interface IServiceBase<T> : IDisposable where T : BaseEntity<T>
    {
        IServiceBase<T> SetDbContext<TContext>(TContext context);
        IServiceBase<T> Add(T pObj);        
        T Get(int pId);        
        IEnumerable<T> Get();               
        IServiceBase<T> Update(T pObj);        
        IServiceBase<T> Delete(int pId);        
    }
}