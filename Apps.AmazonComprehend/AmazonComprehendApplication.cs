using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Metadata;

namespace Apps.AmazonComprehend;

public class AmazonComprehendApplication : IApplication, ICategoryProvider
{
    public IEnumerable<ApplicationCategory> Categories
    {
        get => [ApplicationCategory.ArtificialIntelligence, ApplicationCategory.AmazonApps];
        set { }
    }
    
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