using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Infrastructure.Persistence.Contexts;
using LazaBarbershop.Infrastructure.Persistence.Repositories;
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
        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddTransient<IAppointmentRepository, AppointmentRepository>();
        services.AddTransient<IBarbershopRepository, BarbershopRepository>();
        services.AddTransient<IScheduleRepository, ScheduleRepository>();
    }
}