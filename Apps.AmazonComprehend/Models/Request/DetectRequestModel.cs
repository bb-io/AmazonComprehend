using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonComprehend.Models.Request;

public record DetectRequestModel
{
    public string Text { get; set; }
    [Display("Language code")] public string LanguageCode { get; set; }
}