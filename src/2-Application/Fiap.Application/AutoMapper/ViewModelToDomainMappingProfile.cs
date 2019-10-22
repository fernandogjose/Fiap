using AutoMapper;
using Fiap.Application.ViewModels;
using Fiap.Domain.Entities;

namespace Fiap.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ReceitaViewModel, Receita>();
        }
    }
}
