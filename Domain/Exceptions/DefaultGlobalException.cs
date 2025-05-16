using System.Text.Json.Serialization;

namespace Domain.Exceptions;

public class DefaultGlobalException
{
    [JsonPropertyName("hora")]
    public string? Hora { get; init; }

    [JsonPropertyName("Erro")]
    public string? Notification { get; init; }
}
