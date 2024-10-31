using System.Reflection;
using LazaBarbershop.Core.Application.Interfaces.Services;
using LazaBarbershop.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LazaBarbershop.Core.Application;

public static class ServiceRegistration
{
    public static void AddApplicationLayer(this IServiceCollection services)
    {
        // Register Automapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        
        // Register Services
        services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
        services.AddTransient<IAppointmentService, AppointmentService>();
        services.AddTransient<IBarbershopService, BarbershopService>();
        services.AddTransient<IScheduleService, ScheduleService>();
    }
}