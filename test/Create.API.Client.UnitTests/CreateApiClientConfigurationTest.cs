using Create.API.Client.Configuration;

namespace Create.API.Client.UnitTests
{
    public class CreateApiClientConfigurationTest
    {
        [Fact]
        public void CreateApiClientConfiguration_DefaultValues()
        {
            var configuration = new CreateApiClientConfiguration();

            Assert.NotEqual(string.Empty, configuration.BaseUrl);
            Assert.NotEqual(0, configuration.MaxTimeout);
            Assert.True(configuration.ThrowOnAnyError);
        }

        [InlineData("https://baconipsum.com/api/")]
        [InlineData("https://localhost:3000/")]
        [Theory]
        public void CreateApiClientConfiguration_WithCustomBaseUrl(string baseUrl)
        {
            var configuration = new CreateApiClientConfiguration(baseUrl);

            Assert.Equal(baseUrl, configuration.BaseUrl);
            Assert.Equal(10000, configuration.MaxTimeout);
            Assert.True(configuration.ThrowOnAnyError);
        }

        [InlineData("https://baconipsum.com/api/", 0, true)]
        [InlineData("https://localhost:3000/", 1000, false)]
        [Theory]
        public void CreateApiClientConfiguration_WithCustom(string baseUrl, int maxTimeOut, bool throwOnErrors)
        {
            var configuration = new CreateApiClientConfiguration
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
