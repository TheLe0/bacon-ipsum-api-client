using Bacon.Ipsum.API.Client.Configuration;

namespace Bacon.Ipsum.API.Client.UnitTests
{
    public class BaconIpsumApiClientConfigurationTest
    {
        [Fact]
        public void BaconIpsumApiClientConfiguration_DefaultValues()
        {
            var configuration = new BaconIpsumApiClientConfiguration();

            Assert.NotEqual(string.Empty, configuration.BaseUrl);
            Assert.NotEqual(0, configuration.MaxTimeout);
            Assert.True(configuration.ThrowOnAnyError);
        }

        [InlineData("https://baconipsum.com/api/")]
        [InlineData("https://localhost:3000/")]
        [Theory]
        public void BaconIpsumApiClientConfiguration_WithCustomBaseUrl(string baseUrl)
        {
            var configuration = new BaconIpsumApiClientConfiguration(baseUrl);

            Assert.Equal(baseUrl, configuration.BaseUrl);
            Assert.Equal(10000, configuration.MaxTimeout);
            Assert.True(configuration.ThrowOnAnyError);
        }

        [InlineData("https://baconipsum.com/api/", 0, true)]
        [InlineData("https://localhost:3000/", 1000, false)]
        [Theory]
        public void BaconIpsumApiClientConfiguration_WithCustom(string baseUrl, int maxTimeOut, bool throwOnErrors)
        {
            var configuration = new BaconIpsumApiClientConfiguration
            {
                BaseUrl = baseUrl,
                MaxTimeout = maxTimeOut,
                ThrowOnAnyError = throwOnErrors
            };

            Assert.Equal(baseUrl, configuration.BaseUrl);
            Assert.Equal(maxTimeOut, configuration.MaxTimeout);
            Assert.Equal(throwOnErrors ,configuration.ThrowOnAnyError);
        }
    }
}
