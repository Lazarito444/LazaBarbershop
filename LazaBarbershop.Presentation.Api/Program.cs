using LazaBarbershop.Core.Application;
using LazaBarbershop.Infrastructure.Persistence;
using LazaBarbershop.Presentation.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceLayer(builder.Configuration.GetConnectionString("AppDbConnection")!);
builder.Services.AddPresentationLayer();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "Laza's Barbershop API"));

app.MapControllers();
app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.Run();