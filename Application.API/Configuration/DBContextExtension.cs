using Application.Infastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.API.Configuration
{
    public static class DBContextExtension
    {
        public static void RegisterDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer(config["ConnectionStrings:DefaultConnection"],
            getAssembly => getAssembly.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
            ));
        }
    }
}