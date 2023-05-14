using Bacon.Ipsum.API.Client.Infraestructure;
using Moq;

namespace Bacon.Ipsum.API.Client.Fixture
{
    public static class BaconIpsumApiHttpClientMockFixture
    {
        public static Mock<IBaconIpsumApiHttpClient> SetupMock(this Mock<IBaconIpsumApiHttpClient> mockHttpClient)
        {
            var fixture = BaconIpsumApiClientConfigurationFixture.AutoGenerate();

            mockHttpClient.Setup(_ =>
                _.GetConfiguration())
            .Returns(fixture);

            mockHttpClient.Setup(_ =>
                _.GetBaseUrl())
            .Returns(fixture.BaseUrl);

            return mockHttpClient;
        }
    }
}
