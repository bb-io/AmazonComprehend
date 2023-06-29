using Amazon.Comprehend.Model;
using Apps.AmazonComprehend.Models.Response.Base;

namespace Apps.AmazonComprehend.Models.Response.KeyPhrases;

public record KeyPhraseModel : ComprehendItem
{
    public KeyPhraseModel(KeyPhrase keyPhrase)
    {
        Text = keyPhrase.Text;
        Score = keyPhrase.Score;
    }
}