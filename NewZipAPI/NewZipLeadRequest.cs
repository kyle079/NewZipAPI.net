using System.Text.Json;
using System.Text.Json.Serialization;

namespace NewZipAPI;

public class NewZipLeadRequest
{
    public NewZipLeadRequest(LeadType type, LeadInformation lead, bool live = false, string? reference = null)
    {
        Type = type.ToFriendlyString();
        Live = live;
        Ref = reference;
        Lead = lead;
    }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("live")]
    public bool Live { get; set; }
    [JsonPropertyName("ref")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Ref { get; set; }
    [JsonPropertyName("data")]
    public LeadInformation Lead { get; set; }
    
    public string ToJson() => JsonSerializer.Serialize(this);
}