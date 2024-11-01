namespace LazaBarbershop.Presentation.Api;

public static class ServiceRegistration
{
    public static void AddPresentationLayer(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();
        services.AddCors(options => options.AddPolicy("AllowAll", builder =>
        {
            builder.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
        }));
    }
}