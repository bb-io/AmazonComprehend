using Amazon.Comprehend.Model;
using Apps.AmazonComprehend.Extensions;
using Apps.AmazonComprehend.Models.Response.Base;

namespace Apps.AmazonComprehend.Models.Response.Pii;

public record PiiModel : TypeComprehendItem
{
    public PiiModel(PiiEntity entity, string textInput)
    {
        var textArray = textInput
            .Skip(entity.BeginOffset)
            .Take(entity.EndOffset - entity.BeginOffset)
            .ToArray();

        Text = new(textArray);
        EnumType = entity.Type;
        Type = entity.Type.ToString().ToReadableFormat();
        Score = entity.Score;
    }
}