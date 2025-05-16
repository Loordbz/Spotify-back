using Domain.Exceptions;
using Infra.Middleware.Validations;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Infra.Middleware;

public class GlobalExceptionHandlingMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        var (statusCode, details) = ExceptionValidationHandlingMiddleware.SelectExceptionResponse(context, ex);

        var result = JsonSerializer.Serialize(new DefaultGlobalException
        {
            Hora = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}",
            Notification = details
        });

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = statusCode;

        return context.Response.WriteAsync(result);
    }
}
