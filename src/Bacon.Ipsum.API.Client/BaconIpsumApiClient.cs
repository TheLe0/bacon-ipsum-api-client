using Bacon.Ipsum.API.Client.Configuration;
using Bacon.Ipsum.API.Client.Implementation;
using Bacon.Ipsum.API.Client.Infraestructure;

namespace Bacon.Ipsum.API.Client
{
    public class BaconIpsumApiClient : IBaconIpsumApiClient
    {
        public ITextGenerator TextGenerator { get; private set; }

        public BaconIpsumApiClient(string baseUrl) 
        {
            TextGenerator = new TextGenerator(baseUrl);
        }

        public BaconIpsumApiClient(BaconIpsumApiClientConfiguration configuration) 
        {
            TextGenerator = new TextGenerator(configuration);
        }

        public BaconIpsumApiClient(IBaconIpsumApiHttpClient restApiClient) 
        {
            TextGenerator = new TextGenerator(restApiClient);
        }

        public BaconIpsumApiClient()
        {
            TextGenerator = new TextGenerator();
        }
    }
}
