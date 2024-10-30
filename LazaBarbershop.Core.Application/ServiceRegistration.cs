using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace LazaBarbershop.Core.Application;

public static class ServiceRegistration
{
    public static void AddApplicationLayer(this IServiceCollection services)
    {
        // Register Automapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        
        // Register Services
    }
}