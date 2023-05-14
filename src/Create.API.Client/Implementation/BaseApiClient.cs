using Create.API.Client.Configuration;
using Create.API.Client.Infraestructure;
using Flurl;
using RestSharp;
using System.Threading.Tasks;

namespace Create.API.Client.Implementation
{
    public abstract class BaseApiClient
    {
        private readonly ICreateApiHttpClient _httpClient;
        protected readonly Url Endpoint;

        protected BaseApiClient(string baseUrl)
        {
            _httpClient = new CreateApiHttpClient(baseUrl);
            Endpoint = _httpClient.GetBaseUrl();
        }


        protected BaseApiClient(ICreateApiHttpClient restApiClient)
        {
            _httpClient = restApiClient;
            Endpoint = _httpClient.GetBaseUrl();
        }

        protected BaseApiClient()
        {
            _httpClient = new CreateApiHttpClient();
            Endpoint = _httpClient.GetBaseUrl();
        }

        protected BaseApiClient(CreateApiClientConfiguration configuration)
        {
            _httpClient = new CreateApiHttpClient(configuration);
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
