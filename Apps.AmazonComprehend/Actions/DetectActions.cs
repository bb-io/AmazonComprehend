using Amazon.Comprehend.Model;
using Apps.AmazonComprehend.Factories;
using Apps.AmazonComprehend.Models.Request;
using Apps.AmazonComprehend.Models.Response.Entities;
using Apps.AmazonComprehend.Models.Response.KeyPhrases;
using Apps.AmazonComprehend.Models.Response.Language;
using Apps.AmazonComprehend.Models.Response.Pii;
using Apps.AmazonComprehend.Models.Response.Sentiment;
using Apps.AmazonComprehend.Models.Response.Syntax;
using Apps.AmazonComprehend.Utils;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Authentication;

namespace Apps.AmazonComprehend.Actions;

[ActionList]
public class DetectActions
{
    #region Actions

    [Action("Detect entities", Description = "Detect entities in a document")]
    public async Task<EntitiesResponseModel> DetectEntities(
        IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
        [ActionParameter] DetectRequestModel requestModel)
    {
        var client = ComprehendClientFactory.CreateClientWithCreds(authenticationCredentialsProviders.ToArray());

        var request = new DetectEntitiesRequest
        {
            Text = requestModel.Text,
            LanguageCode = requestModel.LanguageCode,
        };

        var response = await RequestsHandler.ExecutePollyAction(client.DetectEntitiesAsync, request);
        var entities = response.Entities.Select(x => new EntityModel(x)).ToArray();

        return new(entities);
    }
    
    [Action("Detect key phrases", Description = "Detect key phrases in a document")]
    public async Task<KeyPhrasesResponse> DetectKeyPhrases(
        IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
        [ActionParameter] DetectRequestModel requestModel)
    {
        var client = ComprehendClientFactory.CreateClientWithCreds(authenticationCredentialsProviders.ToArray());

        var request = new DetectKeyPhrasesRequest
        {
            Text = requestModel.Text,
            LanguageCode = requestModel.LanguageCode,
        };

        var response = await RequestsHandler.ExecutePollyAction(client.DetectKeyPhrasesAsync, request);
        var keyPhrases = response.KeyPhrases.Select(x => new KeyPhraseModel(x)).ToArray();

        return new(keyPhrases);
    }
    
    [Action("Detect personally identifiable information", Description = "Detect personally identifiable information in a document")]
    public async Task<PiiResponse> DetectPii(
        IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
        [ActionParameter] DetectRequestModel requestModel)
    {
        var client = ComprehendClientFactory.CreateClientWithCreds(authenticationCredentialsProviders.ToArray());

        var inputText = requestModel.Text;
        var request = new DetectPiiEntitiesRequest
        {
            Text = inputText,
            LanguageCode = requestModel.LanguageCode,
        };

        var response = await RequestsHandler.ExecutePollyAction(client.DetectPiiEntitiesAsync, request);
        var piiEntities = response.Entities.Select(x => new PiiModel(x, inputText)).ToArray();

        return new(piiEntities);
    }
    
    [Action("Detect syntactical elements", Description = "Detect syntactical elements of a document")]
    public async Task<SyntaxElementsResponse> DetectSyntacticalElements(
        IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
        [ActionParameter] DetectRequestModel requestModel)
    {
        var client = ComprehendClientFactory.CreateClientWithCreds(authenticationCredentialsProviders.ToArray());

        var request = new DetectSyntaxRequest
        {
            Text = requestModel.Text,
            LanguageCode = requestModel.LanguageCode,
        };

        var response = await RequestsHandler.ExecutePollyAction(client.DetectSyntaxAsync, request);
        var syntaxElements = response.SyntaxTokens.Select(x => new SyntaxElement(x)).ToArray();

        return new(syntaxElements);
    }
    
    [Action("Detect dominant language", Description = "Detect the dominant language in a document")]
    public async Task<LanguageResponse> DetectDominantLanguage(
        IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
        [ActionParameter] [Display("Text")] string text)
    {
        var client = ComprehendClientFactory.CreateClientWithCreds(authenticationCredentialsProviders.ToArray());

        var request = new DetectDominantLanguageRequest
        {
            Text = text
        };

        var response = await RequestsHandler.ExecutePollyAction(client.DetectDominantLanguageAsync, request);
        var languages = response.Languages.Select(x => new LanguageModel(x)).ToArray();

        return new(languages);
    }
    
    [Action("Detect sentiment", Description = "Detect the sentiment of a document")]
    public async Task<SentimentResponse> DetectSentiment(
        IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
        [ActionParameter] DetectRequestModel requestModel)
    {
        var client = ComprehendClientFactory.CreateClientWithCreds(authenticationCredentialsProviders.ToArray());

        var request = new DetectSentimentRequest
        {
            Text = requestModel.Text,
            LanguageCode = requestModel.LanguageCode
        };

        var response = await RequestsHandler.ExecutePollyAction(client.DetectSentimentAsync, request);

        return new(response);
    }

    #endregion
}