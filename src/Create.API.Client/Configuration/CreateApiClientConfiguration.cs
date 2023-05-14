using Create.API.Client.Resources;

namespace Create.API.Client.Configuration
{
    public class CreateApiClientConfiguration : RestSharpConfiguration
    {
        public CreateApiClientConfiguration(string baseUrl)
        {
            BaseUrl = baseUrl;

            SetupDefaultConfigs();
        }

        public CreateApiClientConfiguration()
        {
            BaseUrl = Routes.BaseApiPath;

            SetupDefaultConfigs();
        }
    }
}
