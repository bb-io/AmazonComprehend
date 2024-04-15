using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.AmazonComprehend.DataSourceHandler;

public class LanguageDataHandler : IStaticDataSourceHandler
{
    public Dictionary<string, string> GetData()
        => new()
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