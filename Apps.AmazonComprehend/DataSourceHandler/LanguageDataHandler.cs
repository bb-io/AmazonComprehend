using Blackbird.Applications.Sdk.Utils.Sdk.DataSourceHandlers;

namespace Apps.AmazonComprehend.DataSourceHandler;

public class LanguageDataHandler : EnumDataHandler
{
    protected override Dictionary<string, string> EnumValues => new()
    {
        { "ar", "Arabic" },
        { "de", "German" },
        { "en", "English" },
        { "es", "Spanish" },
        { "fr", "French" },
        { "hi", "Hindi" },
        { "it", "Italian" },
        { "ja", "Japanese" },
        { "ko", "Korean" },
        { "pt", "Portuguese" },
        { "zh", "Chinese" },
        { "zh-TW", "Traditional Chinese" }
    };
}