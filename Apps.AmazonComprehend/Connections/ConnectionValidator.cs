using Amazon.Comprehend.Model;
using Apps.AmazonComprehend.Factories;
using Apps.AmazonComprehend.Utils;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Connections;

namespace Apps.AmazonComprehend.Connections;

public class ConnectionValidator : IConnectionValidator
{
    public async ValueTask<ConnectionValidationResponse> ValidateConnection(
        IEnumerable<AuthenticationCredentialsProvider> authProviders, CancellationToken cancellationToken)
    {
        var client = ComprehendClientFactory.CreateClientWithCreds(authProviders.ToArray());

        var request = new DetectEntitiesRequest
        {
            Text = "Test connection validation",
            LanguageCode = "en",
        };

        try
        {
            await RequestsHandler.ExecutePollyAction(client.DetectEntitiesAsync, request);

            return new()
            {
                IsValid = true
            };
        }
        catch (Exception ex)
        {
            return new()
            {
                IsValid = false,
                Message = ex.Message
            };
        }
    }
}