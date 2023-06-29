using Amazon;
using Amazon.Comprehend;
using Apps.AmazonComprehend.Constants;
using Blackbird.Applications.Sdk.Common.Authentication;

namespace Apps.AmazonComprehend.Factories;

public static class ComprehendClientFactory
{
    public static AmazonComprehendClient CreateClientWithCreds(
        AuthenticationCredentialsProvider[] authenticationCredentialsProviders)
    {
        var key = authenticationCredentialsProviders.First(p => p.KeyName == "access_key");
        var secret = authenticationCredentialsProviders.First(p => p.KeyName == "access_secret");

        if (string.IsNullOrEmpty(key.Value) || string.IsNullOrEmpty(secret.Value))
            throw new Exception(ExceptionMessages.CredentialsMissing);

        return new(key.Value, secret.Value, new AmazonComprehendConfig
        {
            RegionEndpoint = RegionEndpoint.USEast1
        });
    }
}