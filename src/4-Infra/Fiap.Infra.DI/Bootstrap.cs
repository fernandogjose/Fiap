using AutoMapper;
using Fiap.Application.AppServices;
using Fiap.Application.Interfaces.AppServices;
using Fiap.Domain.Interfaces.DomainServices;
using Fiap.Domain.Interfaces.Repositories;
using Fiap.Domain.Services;
using Fiap.Domain.Validations;
using Fiap.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Infra.DI
{
    public class Bootstrap
    {

        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton((IConfigurationProvider)Application.AutoMapper.AutoMapperConfiguration.RegisterMappings());
            services.AddScoped<IMapper>(x => new Mapper(x.GetRequiredService<IConfigurationProvider>(), x.GetService));
            services.AddSingleton<ReceitaValidation>();
            services.AddScoped<IReceitaAppService, ReceitaAppService>();
            services.AddScoped<IReceitaService, ReceitaService>();
            services.AddScoped<IReceitaRepository, ReceitaRepository>();
        }
    }
}