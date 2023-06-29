using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonComprehend.Models.Response.Pii;

public record PiiResponse([property: Display("Personally identifiable information entities")] PiiModel[] PiiEntities);
