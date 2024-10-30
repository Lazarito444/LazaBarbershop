using LazaBarbershop.Infrastructure.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace LazaBarbershop.Infrastructure.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceLayer(this IServiceCollection services, string connectionString)
    {
        // Register DbContext
        services.AddSqlServer<AppDbContext>(connectionString, builder =>
        {
            builder.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
        });
        
        // Register Repositories
    }
}