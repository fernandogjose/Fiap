using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fiap.Domain.Interfaces.DomainServices
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<List<TEntity>> Get();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        Task Delete(int id);
    }
}
