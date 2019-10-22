using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fiap.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        Task<List<T>> Get();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        Task Delete(int id);
    }
}
