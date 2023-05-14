using Bacon.Ipsum.API.Client.Resources;

namespace Bacon.Ipsum.API.Client.Configuration
{
    public class BaconIpsumApiClientConfiguration : RestSharpConfiguration
    {
        public TextContentType Type { get; set; }
        public bool StartWithLorem { get; set; }

        public BaconIpsumApiClientConfiguration(string baseUrl)
        {
            BaseUrl = baseUrl;

            SetupDefault();
        }

        public BaconIpsumApiClientConfiguration()
        {
            BaseUrl = Routes.BaseApiPath;

            SetupDefault();
        }

        public void SetupDefault()
        {
            Type = TextContentType.ALL_MEAT;
            StartWithLorem = false;

            SetupDefaultConfigs();
        }
    }
}
