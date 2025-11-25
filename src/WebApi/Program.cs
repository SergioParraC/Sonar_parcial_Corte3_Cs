using WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Services.AddApplicationServices();

var app = builder.Build();

app.UseApplicationPipeline();

app.Run();