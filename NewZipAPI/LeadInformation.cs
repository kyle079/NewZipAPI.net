using System.ComponentModel;
using System.Text.Json;

namespace NewZipAPI;

public class LeadInformation
{
    LeadInformation(string firstName, 
        string lastName, 
        string email, 
        string phone, 
        bool preApproved,
        string location, 
        string budget,
        string? message, double? baths, int? area, double beds = default,
        List<KeyValuePair<string, string>> customDetails = null!, 
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

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public bool PreApproved { get; set; }
    public string Location { get; set; }
    public string Budget { get; set; }
    public List<KeyValuePair<string, string>> CustomDetails { get; set; }
    public string? PropertyType { get; set; }
    public string? Timeline { get; set; }
    public string? Message { get; set; }
    public double? Beds { get; set; }
    public double? Baths { get; set; }
    public int? Area { get; set; }
    
    public string ToJson() => JsonSerializer.Serialize(this);
}