using Bacon.Ipsum.API.Client.Configuration;
using Bacon.Ipsum.API.Client.Resources;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace Bacon.Ipsum.API.Client.Infraestructure
{
    public class BaconIpsumApiHttpClient : IBaconIpsumApiHttpClient
    {
        private readonly RestClient _client;
        private readonly BaconIpsumApiClientConfiguration _configuration;

        public BaconIpsumApiHttpClient(BaconIpsumApiClientConfiguration configuration)
        {
            _configuration = configuration;
            _client = new RestClient(GetConfigurations());
        }

        public BaconIpsumApiHttpClient()
        {
            _configuration = new BaconIpsumApiClientConfiguration();
            _client = new RestClient(GetConfigurations());
        }

        public BaconIpsumApiHttpClient(string baseUrl)
        {
            _configuration = new BaconIpsumApiClientConfiguration(baseUrl);
            _client = new RestClient(GetConfigurations());
        }

        public string GetBaseUrl()
        {
            return _configuration.BaseUrl;
        }

        public BaconIpsumApiClientConfiguration GetConfiguration()
        {
            return _configuration;
        }

        public Task<T> GetAsync<T>(RestRequest request)
        {
            return _client.GetAsync<T>(request);
        }

        private RestClientOptions GetConfigurations()
        {
            return new RestClientOptions(_configuration.BaseUrl)
            {
                ThrowOnAnyError = _configuration.ThrowOnAnyError,
                MaxTimeout = _configuration.MaxTimeout
            };
        }
    }
}
