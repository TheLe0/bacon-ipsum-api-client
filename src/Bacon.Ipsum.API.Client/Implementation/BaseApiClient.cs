using Bacon.Ipsum.API.Client.Configuration;
using Bacon.Ipsum.API.Client.Infraestructure;
using Flurl;
using RestSharp;
using System.Threading.Tasks;

namespace Bacon.Ipsum.API.Client.Implementation
{
    public abstract class BaseApiClient
    {
        private readonly IBaconIpsumApiHttpClient _httpClient;
        protected readonly Url Endpoint;

        protected BaseApiClient(string baseUrl)
        {
            _httpClient = new BaconIpsumApiHttpClient(baseUrl);
            Endpoint = _httpClient.GetBaseUrl();
        }


        protected BaseApiClient(IBaconIpsumApiHttpClient restApiClient)
        {
            _httpClient = restApiClient;
            Endpoint = _httpClient.GetBaseUrl();
        }

        protected BaseApiClient()
        {
            _httpClient = new BaconIpsumApiHttpClient();
            Endpoint = _httpClient.GetBaseUrl();
        }

        protected BaseApiClient(BaconIpsumApiClientConfiguration configuration)
        {
            _httpClient = new BaconIpsumApiHttpClient(configuration);
            Endpoint = _httpClient.GetBaseUrl();
        }

        protected Task<T> GetAsync<T>()
        {
            var restRequest = new RestRequest(Endpoint.ToString());
            RefreshEndpoint();

            return _httpClient.GetAsync<T>(restRequest);
        }

        private void RefreshEndpoint()
        {
            Endpoint.Reset();
        }
    }
}
