using AutoMapper;
using Avivatec.Certa.Operacao.Core.Application.AppServices;
using Fiap.Application.Interfaces.AppServices;
using Fiap.Domain.Entities;
using Fiap.Domain.Interfaces.DomainServices;

namespace Fiap.Application.AppServices
{
    public class ReceitaAppService : AppServiceBase<Receita>, IReceitaAppService
    {
        public ReceitaAppService(IReceitaService receitaService, IMapper mapper) : base(receitaService, mapper)
        {
        }
    }
}