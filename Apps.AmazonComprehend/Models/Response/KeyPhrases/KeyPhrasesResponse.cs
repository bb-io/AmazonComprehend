using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonComprehend.Models.Response.KeyPhrases;

public record KeyPhrasesResponse([property: Display("Key phrases")] KeyPhraseModel[] KeyPhrases);