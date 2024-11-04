using System.Reflection;
using Asp.Versioning;
using Microsoft.OpenApi.Models;

namespace LazaBarbershop.Presentation.Api;

public static class ServiceRegistration
{
    public static void AddPresentationLayer(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ReportApiVersions = true;
            options.ApiVersionReader = new HeaderApiVersionReader("X-version");
        });
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            List<string> xmlFiles = Directory
                .GetFiles(AppContext.BaseDirectory, "*.xml", searchOption: SearchOption.TopDirectoryOnly).ToList();
            xmlFiles.ForEach(xmlFile => options.IncludeXmlComments(xmlFile));
            options.DescribeAllParametersInCamelCase();
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Laza's Barbershop API",
                Description = "This API provides a way to execute database operations such as create, insert, update and delete.",
                Version = "v1",
                Contact = new OpenApiContact
                {
                    Name = "Ariel David Lázaro Pérez",
                    Email = "ariellazaro444@gmail.com",
                    Url = new Uri("https://github.com/Lazarito444")
                }
            });
        });
        services.AddControllers();
        services.AddCors(options => options.AddPolicy("AllowAll", builder =>
        {
            builder.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
        }));
    }
}