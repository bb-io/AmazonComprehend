namespace Apps.AmazonComprehend.Models.Response.Base;

public record ComprehendItem
{
    public string Text { get; init; }
    public float Score { get; init; }
    
}