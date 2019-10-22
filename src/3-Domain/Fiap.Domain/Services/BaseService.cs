using Fiap.Domain.Interfaces.DomainServices;
using Fiap.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fiap.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<List<TEntity>> Get()
        {
            return await _repository.Get();
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public virtual void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
