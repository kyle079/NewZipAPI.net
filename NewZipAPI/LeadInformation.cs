using System.Text.Json;
using System.Text.Json.Serialization;

namespace NewZipAPI;

public class LeadInformation
{
    public LeadInformation(string firstName,
        string lastName,
        string email,
        string phone,
        bool preApproved,
        string location,
        double budget,
        string? message = null, 
        int? area = null, 
        double? beds = null,
        double? baths = null,
        Dictionary<string, string>? customDetails = null,
        NewZipTimeline timeline = default,
        NewZipPropertyType propertyType = default)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        PreApproved = preApproved;
        Location = location;
        Budget = budget;
        CustomDetails = customDetails;
        PropertyType = propertyType.ToFriendlyString();
        Timeline = timeline.ToFriendlyString();
        Message = message;
        Baths = baths;
        Area = area;
        Beds = beds;
    }

    [JsonPropertyName("firstname")]
    public string FirstName { get; set; }

    [JsonPropertyName("lastname")]
    public string LastName { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("preapproved")]
    public bool PreApproved { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("budget")]
    public double Budget { get; set; }

    [JsonPropertyName("custom")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, string>? CustomDetails { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("property_type")]
    public string? PropertyType { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeline")]
    public string? Timeline { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beds")]
    public double? Beds { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baths")]
    public double? Baths { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("area")]
    public int? Area { get; set; }

    public string ToJson() => JsonSerializer.Serialize(this);
}