using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SP.Infrastructure.Persistences.Contexts;
using SP.Infrastructure.Persistences.Interfaces;
using SP.Infrastructure.Persistences.Repositories;

namespace SP.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(SoporteContext).Assembly.FullName;
            services.AddDbContext<SoporteContext>(
                options => options.UseNpgsql(
                    configuration.GetConnectionString("SoporteConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
