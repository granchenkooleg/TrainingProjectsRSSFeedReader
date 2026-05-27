using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<SubscriptionStore>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("LocalCors", policy =>
    {
        policy.WithOrigins("http://localhost:5213", "https://localhost:5213")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors("LocalCors");
app.MapControllers();
app.Run();
