using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonComprehend.Models.Response.Base;

public record TypeComprehendItem : ComprehendItem
{
    [Display("Enum type")] public string EnumType { get; init; }
    [Display("Type")] public string Type { get; init; }
}