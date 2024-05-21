using DesignPatterns.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.DependecyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection InfraestructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DesignPatternsConsoleDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ServiceContainer).Assembly.FullName)),
                ServiceLifetime.Scoped);

            return services;
        }
    }
}
