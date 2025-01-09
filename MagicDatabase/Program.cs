using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting; // Necessario per Entity Framework
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Hosting;
using MagicCardsAPI.Data;
using MagicDatabase;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MagicDatabase.Services;


var builder = WebApplication.CreateBuilder(args);
//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MagicCardsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MagicDatabase")));
builder.Services.AddControllers();
builder.Services.AddScoped<CardService>();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Magic Cards API",
        Version = "v1",
        Description = "API per gestire il database delle Magic Cards con autenticazione JWT."
    });

    // To Enable authorization using Swagger (JWT)

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {

        Name = "Authorization",

        Type = SecuritySchemeType.ApiKey,

        Scheme = "Bearer",

        BearerFormat = "JWT",

        In = ParameterLocation.Header,

        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",

    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {

                    {

                        new OpenApiSecurityScheme
                        {

                            Reference = new OpenApiReference

                            {

                                Type = ReferenceType.SecurityScheme,

                                Id = "Bearer"

                            }

                        },

                        new string[] {}

                    }

                });

});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {

                    options.TokenValidationParameters = new TokenValidationParameters
                    {

                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Secret"])),

                    };
                    // Enable logging for debugging
                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            Console.WriteLine($"Authentication failed: {context.Exception.Message}");
                            return System.Threading.Tasks.Task.CompletedTask;
                        },
                        OnTokenValidated = context =>
                        {
                            Console.WriteLine("Token validated successfully.");
                            return System.Threading.Tasks.Task.CompletedTask;
                        }
                    };

                });

builder.Services.AddScoped<JwtService>();

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
