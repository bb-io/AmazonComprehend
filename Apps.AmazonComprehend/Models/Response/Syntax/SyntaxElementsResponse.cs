using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonComprehend.Models.Response.Syntax;

public record SyntaxElementsResponse([property: Display("Syntax elements")] SyntaxElement[] SyntaxElements);
