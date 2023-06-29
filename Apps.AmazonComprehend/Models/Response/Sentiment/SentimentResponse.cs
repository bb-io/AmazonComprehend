using Amazon.Comprehend.Model;
using Apps.AmazonComprehend.Extensions;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonComprehend.Models.Response.Sentiment;

public record SentimentResponse
{
    public SentimentResponse(DetectSentimentResponse response)
    {
        Type = response.Sentiment.ToString().ToReadableFormat();
        Mixed = response.SentimentScore.Mixed;
        Negative = response.SentimentScore.Negative;
        Neutral = response.SentimentScore.Neutral;
        Positive = response.SentimentScore.Positive;
    }

    [Display("Sentiment type")] public string Type { get; init; }
    [Display("Mixed sentiment score")] public float Mixed { get; init; }
    [Display("Negative sentiment score")] public float Negative { get; init; }
    [Display("Neutral sentiment score")] public float Neutral { get; init; }
    [Display("Positive sentiment score")] public float Positive { get; init; }
}