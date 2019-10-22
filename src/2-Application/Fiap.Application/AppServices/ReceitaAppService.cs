using AutoMapper;
using Fiap.Application.Interfaces.AppServices;
using Fiap.Domain.Interfaces.DomainServices;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Application.AppServices
{
    public class ReceitaAppService : IReceitaAppService
    {
        private readonly IReceitaService _receitaService;
        private readonly IMapper _mapper;

        public ReceitaAppService(IReceitaService receitaService, IMapper mapper)
        {
            _receitaService = receitaService;
            _mapper = mapper;
        }
    }
}