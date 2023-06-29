using System.Globalization;
using System.Text;

namespace Apps.AmazonComprehend.Extensions;

public static class StringExtensions
{
    public static string ToReadableFormat(this string inputText)
    {
        var parts = inputText.Split('_');
        var result = new StringBuilder();

        foreach (var part in parts)
        {
            var formattedPart = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(part.ToLower());
            result.Append(formattedPart).Append(" ");
        }

        return result.ToString().TrimEnd();
    }
}