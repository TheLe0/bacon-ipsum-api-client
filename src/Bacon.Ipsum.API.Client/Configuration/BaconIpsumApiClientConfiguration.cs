using Bacon.Ipsum.API.Client.Resources;

namespace Bacon.Ipsum.API.Client.Configuration
{
    public class BaconIpsumApiClientConfiguration : RestSharpConfiguration
    {
        public BaconIpsumApiClientConfiguration(string baseUrl)
        {
            BaseUrl = baseUrl;

            SetupDefaultConfigs();
        }

        public BaconIpsumApiClientConfiguration()
        {
            BaseUrl = Routes.BaseApiPath;

            SetupDefaultConfigs();
        }
    }
}
