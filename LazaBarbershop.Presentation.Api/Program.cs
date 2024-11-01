using LazaBarbershop.Core.Application;
using LazaBarbershop.Infrastructure.Persistence;
using LazaBarbershop.Presentation.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceLayer(builder.Configuration.GetConnectionString("AppDbConnection")!);
builder.Services.AddPresentationLayer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.Run();