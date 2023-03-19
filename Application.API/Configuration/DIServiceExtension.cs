using Application.Application.Mapper;
using Application.Application.Services.Implementations;
using Application.Application.Services.Interfaces;
using Application.Infastructure.Repositories.Interfaces;
using Application.Infrastructure.Repositories.Implementations;
using Application.Infrastructure.Repositories.Interfaces;

namespace Application.API.Configuration
{
    public static class DIServiceExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddAutoMapper(typeof(AppFormMapper));
            services.AddScoped<IProgramDetailService, ProgramDetailService>();
            services.AddScoped<IProgramDetailsRepository, ProgramDetailsRepository>();
            services.AddScoped<IPreviewRepository, PreviewRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}