namespace NewZipAPI;

public enum NewZipPropertyType
{
    Unknown,
    SingleFamily,
    Townhouse,
    Condominium,
    Other
}

public static class NewZipPropertyTypeExtensions
{
    public static string ToFriendlyString(this NewZipPropertyType propertyType)
    {
        return propertyType switch
        {
            NewZipPropertyType.Unknown => "",
            NewZipPropertyType.SingleFamily => "Single-Family",
            NewZipPropertyType.Townhouse => "Townhouse",
            NewZipPropertyType.Condominium => "Condominium",
            NewZipPropertyType.Other => "Other",
            _ => throw new ArgumentOutOfRangeException(nameof(propertyType), propertyType, null)
        };
    }
}