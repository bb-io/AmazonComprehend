using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonComprehend;

public class AmazonComprehendApplication : IApplication
{
    public string Name
    {
        get => "Amazon Comprehend";
        set { }
    }

    public T GetInstance<T>()
    {
        throw new NotImplementedException();
    }
}