using Fiap.Domain.Entities;
using Fiap.Domain.Interfaces.DomainServices;
using Fiap.Domain.Interfaces.Repositories;

namespace Fiap.Domain.Services
{
    public class ReceitaService : BaseService<Receita>, IReceitaService
    {
        private readonly IReceitaRepository _receitaRepository;

        public ReceitaService(IReceitaRepository receitaRepository) : base(receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }
    }
}