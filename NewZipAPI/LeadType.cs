namespace NewZipAPI;

public enum LeadType
{
    Buyer,
    Seller
}

public static class LeadTypeExtensions
{
    public static string ToFriendlyString(this LeadType leadType)
    {
        return leadType switch
        {
            LeadType.Buyer => "buyer",
            LeadType.Seller => "seller",
            _ => throw new ArgumentOutOfRangeException(nameof(leadType), leadType, null)
        };
    }
}