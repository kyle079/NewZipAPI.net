using System.Text.Json;
using System.Text.Json.Serialization;

namespace NewZipAPI;

public class NewZipResponse
{
    public NewZipResponse(bool test, bool success, string message, int status)
    {
        Test = test;
        Success = success;
        Message = message;
        Status = status;
    }

    [JsonPropertyName("test")]
    public bool Test { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }
}