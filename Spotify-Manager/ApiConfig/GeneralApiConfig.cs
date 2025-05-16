using Domain.Interface.Repository;
using Domain.Interface.Service;
using Infra.Middleware;
using Infra.Repository;
using Service.Services;

namespace Service.API.ApiConfig;

public static class GeneralApiConfig
{
    public static IServiceCollection AddGeneralApiServices(this IServiceCollection services)
    {
        services.AddScoped<ISpotifyService, SpotifyService>();
        return services;
    }

    public static IServiceCollection AddGeneralApiRepositories(this IServiceCollection services)
    {
        services.AddScoped<ISpotifyRepository, SpotifyRepository>();
        return services;
    }

    public static IServiceCollection AddCorsConfiguration(this IServiceCollection services) =>
        services.AddCors(opt =>
        {
            opt.AddPolicy("Total", builder =>
                builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
            );
        });

    public static IApplicationBuilder UseCustomExceptionMiddleware(this IApplicationBuilder app) =>
        app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
}
