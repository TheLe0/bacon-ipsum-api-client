using Bacon.Ipsum.API.Client.Fixture;
using Bacon.Ipsum.API.Client.Infraestructure;
using RestSharp;

namespace Bacon.Ipsum.API.Client.UnitTests
{
    public class TextGeneratorTest
    {
        private readonly IBaconIpsumApiClient _client;
        private readonly Mock<IBaconIpsumApiHttpClient> _mockHttpClient;

        public TextGeneratorTest()
        {
            _mockHttpClient = new Mock<IBaconIpsumApiHttpClient>()
                .SetupMock();
            _client = new BaconIpsumApiClient(_mockHttpClient.Object);
        }

        [Fact]
        public async void GenerateSentenceAsync_Success()
        {
            _mockHttpClient.Setup(_ =>
                _.GetAsync<IEnumerable<string>>(It.IsAny<RestRequest>()))
                .ReturnsAsync(TextGeneratorFixture.AutoGenerate(100));

            var text = await _client.TextGenerator.GenerateSentenceAsync(1);

            Assert.NotNull(text);
            Assert.NotEqual(string.Empty, text);
        }

        [Fact]
        public async void GenerateSentenceAsync_Fail_InvalidParameter()
        {
            var text = await _client.TextGenerator.GenerateSentenceAsync(0);

            Assert.Equal(string.Empty, text);
        }

        [Fact]
        public async void GenerateSentenceAsync_Fail_NullResponse()
        {
            _mockHttpClient.Setup(_ =>
                _.GetAsync<IEnumerable<string>>(It.IsAny<RestRequest>()))
                .ReturnsAsync((IEnumerable<string>) null);

            var text = await _client.TextGenerator.GenerateSentenceAsync(1);

            Assert.NotNull(text);
            Assert.Equal(string.Empty, text);
        }

        [Fact]
        public async void GenerateParagraphAsync_Success()
        {
            _mockHttpClient.Setup(_ =>
                _.GetAsync<IEnumerable<string>>(It.IsAny<RestRequest>()))
                .ReturnsAsync(TextGeneratorFixture.AutoGenerate(100));

            var text = await _client.TextGenerator.GenerateParagraphAsync(1);

            Assert.NotNull(text);
            Assert.NotEqual(string.Empty, text);
        }

        [Fact]
        public async void GenerateParagraphAsync_Fail_InvalidParameter()
        {
            var text = await _client.TextGenerator.GenerateParagraphAsync(0);

            Assert.Equal(string.Empty, text);
        }

        [Fact]
        public async void GenerateParagraphAsync_Fail_NullResponse()
        {
            _mockHttpClient.Setup(_ =>
                _.GetAsync<IEnumerable<string>>(It.IsAny<RestRequest>()))
                .ReturnsAsync((IEnumerable<string>)null);

            var text = await _client.TextGenerator.GenerateParagraphAsync(1);

            Assert.NotNull(text);
            Assert.Equal(string.Empty, text);
        }
    }
}
