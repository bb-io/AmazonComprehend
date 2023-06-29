using Amazon.Comprehend.Model;
using Apps.AmazonComprehend.Extensions;
using Apps.AmazonComprehend.Models.Response.Base;

namespace Apps.AmazonComprehend.Models.Response.Entities;

public record EntityModel : TypeComprehendItem
{
    public EntityModel(Entity entity)
    {
        Text = entity.Text;
        Score = entity.Score;
        EnumType = entity.Type;
        Type = entity.Type.ToString().ToReadableFormat();
    }
}