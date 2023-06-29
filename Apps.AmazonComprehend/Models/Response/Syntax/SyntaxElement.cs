using Amazon.Comprehend.Model;
using Apps.AmazonComprehend.Models.Response.Base;

namespace Apps.AmazonComprehend.Models.Response.Syntax;

public record SyntaxElement : TypeComprehendItem
{
    public SyntaxElement(SyntaxToken syntaxToken)
    {
        Text = syntaxToken.Text;
        Score = syntaxToken.PartOfSpeech.Score;
        EnumType = syntaxToken.PartOfSpeech.Tag;
        Type = ParsePartOfSpeech(syntaxToken.PartOfSpeech.Tag);
    }

    private string ParsePartOfSpeech(string tag)
    {
        return tag switch
        {
            "ADJ" => "Adjective",
            "ADP" => "Adposition",
            "ADV" => "Adverb",
            "AUX" => "Auxiliary",
            "CCONJ" => "Coordinating conjunction",
            "CONJ" => "Conjunction",
            "DET" => "Determiner",
            "INTJ" => "Interjection",
            "NOUN" => "Noun",
            "NUM" => "Numeral",
            "O" => "Other",
            "PART" => "Particle",
            "PRON" => "Pronoun",
            "PROPN" => "Proper noun",
            "PUNCT" => "Punctuation",
            "SCONJ" => "Subordinating conjunction",
            "SYM" => "Symbol",
            "VERB" => "Verb",
            _ => "Unknown"
        };
    }
}