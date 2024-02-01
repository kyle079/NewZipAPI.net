namespace NewZipAPI;

public enum NewZipPropertyType
{
    Default,
    Other,
    SingleFamily,
    Townhouse,
    Condominium
}

public static class NewZipPropertyTypeExtensions
{
    public static string? ToFriendlyString(this NewZipPropertyType propertyType)
    {
        return propertyType switch
        {
            NewZipPropertyType.Default => null,
            NewZipPropertyType.SingleFamily => "Single-Family",
            NewZipPropertyType.Townhouse => "Townhouse",
            NewZipPropertyType.Condominium => "Condominium",
            NewZipPropertyType.Other => "Other",
            _ => throw new ArgumentOutOfRangeException(nameof(propertyType), propertyType, null)
        };
    }
}