using Fiap.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Fiap.Application.Interfaces.AppServices
{
    public interface IAppServiceBase<T> : IDisposable where T : BaseEntity<T>
    {
        void Add(T entidade);
        void Update(T entidade);
        T Get(int pId);
        IEnumerable<T> List();
        void Delete(int pId);
    }
}
