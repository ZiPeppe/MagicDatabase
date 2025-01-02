using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting; // Necessario per Entity Framework
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Hosting;
using MagicCardsAPI.Data;
using MagicDatabase;

var builder = WebApplication.CreateBuilder(args);
//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MagicCardsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MagicDatabase")));
builder.Services.AddControllers();
builder.Services.AddScoped<CardService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Magic Cards API",
        Version = "v1",
        Description = "API per gestire il database delle Magic Cards."
    });
});

var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Magic Cards API v1");
        });
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
