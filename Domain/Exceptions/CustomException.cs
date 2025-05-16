using System.Net;

namespace Domain.Exceptions;

public class CustomException : Exception
{
    public HttpStatusCode StatusCode { get; set; }

    public CustomException()
    { }

    public CustomException(string message)
        : base(message)
    { }

    public CustomException(string message, Exception inner)
        : base(message, inner)
    { }

    public CustomException(string message, HttpStatusCode statusCode)
        : base(message) => StatusCode = statusCode;

    public static CustomException ThrowNewException(HttpStatusCode statusCode, string message)
        => statusCode switch
        {
            HttpStatusCode.BadRequest => new CustomException(string.IsNullOrEmpty(message) ? "Não foi possível processar essa requisição." : message, HttpStatusCode.BadRequest),
            HttpStatusCode.NotFound => new CustomException(string.IsNullOrEmpty(message) ? "Não possível algo a partir dessa requisição." : message, HttpStatusCode.NotFound),
            HttpStatusCode.Forbidden => new CustomException(string.IsNullOrEmpty(message) ? "Acesso negado." : message, HttpStatusCode.Forbidden),
            HttpStatusCode.Unauthorized => new CustomException(string.IsNullOrEmpty(message) ? "Não autorizado." : message, HttpStatusCode.Unauthorized),
            HttpStatusCode.TooManyRequests => new CustomException(string.IsNullOrEmpty(message) ? "Limite de requisição excedido." : message, HttpStatusCode.TooManyRequests),

            _ => new CustomException($"Erro ao processar a requisição: {message}", statusCode)
        };
}