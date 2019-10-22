using AutoMapper;
using Fiap.Application.Interfaces.AppServices;
using Fiap.Domain.Entities;
using Fiap.Domain.Interfaces.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Avivatec.Certa.Operacao.Core.Application.AppServices
{
    public class AppServiceBase<T> : IDisposable, IAppServiceBase<T> where T : BaseEntity<T>
    {
        protected readonly IServiceBase<T> _serviceBase;
        protected readonly IMapper _mapper;

        public AppServiceBase(IServiceBase<T> pServiceBase, IMapper mapper)
        {
            _serviceBase = pServiceBase;
            _mapper = mapper;
        }

      
        #region Methods

        public void Add(T entidade)
        {
            try
            {
                _serviceBase.Add(entidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Get(int pId)
        {
            try
            {
                return _mapper.Map<T>(this._serviceBase.Get(pId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> Get()
        {
            try
            {
                return this._mapper.Map<IEnumerable<T>>(_serviceBase.Get());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T entity)
        {
            try
            {
                _serviceBase.Update(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int pId)
        {
            try
            {
                _serviceBase.Delete(pId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            try
            {
                this._serviceBase.Dispose();
                GC.SuppressFinalize(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
