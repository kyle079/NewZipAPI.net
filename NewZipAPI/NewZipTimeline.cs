namespace NewZipAPI;

public enum NewZipTimeline
{
    Unknown,
    ASAP,
    ThreeToSixMonths,
    SixToTwelveMonths,
    MoreThanTwelveMonths,
    Undecided
}

public static class NewZipTimelineExtensions
{
    public static string ToFriendlyString(this NewZipTimeline timeline)
    {
        return timeline switch
        {
            NewZipTimeline.Unknown => "",
            NewZipTimeline.ASAP => "ASAP",
            NewZipTimeline.ThreeToSixMonths => "Within 3-6 months",
            NewZipTimeline.SixToTwelveMonths => "Within 6-12 months",
            NewZipTimeline.MoreThanTwelveMonths => "More than 12 months out",
            NewZipTimeline.Undecided => "Undecided",
            _ => throw new ArgumentOutOfRangeException(nameof(timeline), timeline, null)
        };
    }
}