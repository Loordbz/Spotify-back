using Infra.Middleware;

namespace Service.API.ApiConfig;

public static class GeneralApiConfig
{
    public static IServiceCollection AddGeneralApiServices(this IServiceCollection services)
    {
        return services;
    }

    public static IServiceCollection AddGeneralApiRepositories(this IServiceCollection services)
    {

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
