using Create.API.Client.Configuration;
using RestSharp;
using System.Threading.Tasks;

namespace Create.API.Client.Infraestructure
{
    public class CreateApiHttpClient : ICreateApiHttpClient
    {
        private readonly RestClient _client;
        private readonly CreateApiClientConfiguration _configuration;

        public CreateApiHttpClient(CreateApiClientConfiguration configuration)
        {
            _configuration = configuration;
            _client = new RestClient(GetConfigurations());
        }

        public CreateApiHttpClient()
        {
            _configuration = new CreateApiClientConfiguration();
            _client = new RestClient(GetConfigurations());
        }

        public CreateApiHttpClient(string baseUrl)
        {
            _configuration = new CreateApiClientConfiguration(baseUrl);
            _client = new RestClient(GetConfigurations());
        }

        public string GetBaseUrl()
        {
            return _configuration.BaseUrl;
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
