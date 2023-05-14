using Create.API.Client.Configuration;
using Create.API.Client.Implementation;
using Create.API.Client.Infraestructure;

namespace Create.API.Client
{
    public class CreateApiClient : ICreateApiClient
    {
        public ITextGenerator TextGenerator { get; private set; }

        public CreateApiClient(string baseUrl) 
        {
            TextGenerator = new TextGenerator(baseUrl);
        }

        public CreateApiClient(CreateApiClientConfiguration configuration) 
        {
            TextGenerator = new TextGenerator(configuration);
        }

        public CreateApiClient(ICreateApiHttpClient restApiClient) 
        {
            TextGenerator = new TextGenerator(restApiClient);
        }

        public CreateApiClient()
        {
            TextGenerator = new TextGenerator();
        }
    }
}
