using System.Text.Json;

namespace NewZipAPI;

public class NewZipLeadRequest
{
    public NewZipLeadRequest(LeadType type, LeadInformation lead, bool live = false, string reference = "")
    {
        Type = type;
        Live = live;
        Ref = reference;
        Lead = lead;
    }
    public LeadType Type { get; set; }
    public bool Live { get; set; }
    public string Ref { get; set; }
    public LeadInformation Lead { get; set; }
    
    public string ToJson() => JsonSerializer.Serialize(this);
}