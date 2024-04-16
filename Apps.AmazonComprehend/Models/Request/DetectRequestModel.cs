using Apps.AmazonComprehend.DataSourceHandler;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.AmazonComprehend.Models.Request;

public record DetectRequestModel
{
    public string Text { get; set; }
    
    [Display("Language")] 
    [StaticDataSource(typeof(LanguageDataHandler))]
    public string LanguageCode { get; set; }
}