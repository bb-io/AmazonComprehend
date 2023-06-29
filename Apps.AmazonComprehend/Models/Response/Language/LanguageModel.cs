using Amazon.Comprehend.Model;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonComprehend.Models.Response.Language;

public record LanguageModel
{
    public LanguageModel(DominantLanguage language)
    {
        Score = language.Score;
        LanguageCode = language.LanguageCode;
    }

    public float Score { get; init; }
    [Display("Language code")] public string LanguageCode { get; init; }
}