using Fiap.Domain.Entities;
using Fiap.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity<T>
    {
        protected readonly Context _contexto;

        public BaseRepository()
        {
            _contexto = new Context();
        }

        public async Task<List<T>> Get()
        {
            return await _contexto.Set<T>()
                    .AsNoTracking()
                    .Where(x => x.DataExclusao == null)
                    .ToListAsync();
        }

        public virtual T Get(int id)
        {
            try
            {
                return _contexto.Set<T>()
                .AsNoTracking()
                .FirstOrDefault(e => e.Id == id);

            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }

        public void Add(T entity)
        {
            try
            {
                entity.DataCriacao = DateTime.Now;
                _contexto.Set<T>().Add(entity);
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                entity.DataAlteracao = DateTime.Now;
                _contexto.Set<T>().Update(entity);
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                var entity = Get(id);
                _contexto.Set<T>().Remove(entity);

                await _contexto.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
