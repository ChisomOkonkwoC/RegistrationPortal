using Application.Infastructure.Repositories.Interfaces;
using Application.Infrastructure.Repositories.Implementations;

namespace Application.API.Configuration
{
    public static class DIServiceExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}