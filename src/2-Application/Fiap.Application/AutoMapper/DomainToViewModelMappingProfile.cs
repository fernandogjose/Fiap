using AutoMapper;
using Fiap.Application.ViewModels;
using Fiap.Domain.Entities;

namespace Fiap.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Receita, ReceitaViewModel>();
        }
    }
}
