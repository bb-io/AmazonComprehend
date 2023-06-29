namespace Apps.AmazonComprehend.Utils;

public static class RequestsHandler
{
    public static async Task<TResponse> ExecutePollyAction<TResponse, TRequest>(
        Func<TRequest, CancellationToken, Task<TResponse>> func,
        TRequest request)
    {
        try
        {
            return await func(request, CancellationToken.None);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}