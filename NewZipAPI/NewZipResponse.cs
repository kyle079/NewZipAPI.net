using System.Text.Json;

namespace NewZipAPI;

public class NewZipResponse
{
    public NewZipResponse(string body)
    {
        var response = JsonSerializer.Deserialize<NewZipResponse>(body);
        if (response == null)
        {
            throw new Exception("Failed to deserialize NewZipResponse");
        }
        Test = response.Test;
        Success = response.Success;
        Status = response.Status;
        Message = response.Message;
    }

    public bool Test { get; set; }
    public bool Success { get; set; }
    public int Status { get; set; }
    public string Message { get; set; }
}