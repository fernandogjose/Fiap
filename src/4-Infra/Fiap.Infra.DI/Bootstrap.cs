using Microsoft.Extensions.DependencyInjection;
using Fiap.Application.AppServices;
using Fiap.Application.Interfaces.AppServices;
using Fiap.Application.Mappers;
using Fiap.Domain.Interfaces.DomainServices;
using Fiap.Domain.Interfaces.Https;
using Fiap.Domain.Services;
using Fiap.Domain.Validations;
using Fiap.Infra.Http.Https;

namespace Fiap.Infra.DI {
    public class Bootstrap {
        
        public static void Configure (IServiceCollection services) {

            //--- validation
            services.AddSingleton<BlogValidation> ();

            //--- mapper
            services.AddSingleton<BlogMapper> ();

            //--- http
            services.AddSingleton<IBlogHttp, BlogHttp> ();

            //--- service
            services.AddSingleton<IBlogService, BlogService> ();

            //--- app service
            services.AddSingleton<IBlogAppService, BlogAppService> ();
        }
    }
}