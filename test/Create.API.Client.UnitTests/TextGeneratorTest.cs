using Create.API.Client.Fixture;
using Create.API.Client.Implementation;
using Create.API.Client.Infraestructure;
using Moq;
using RestSharp;

namespace Create.API.Client.UnitTests
{
    public class TextGeneratorTest
    {
        private readonly ICreateApiClient _client;
        private readonly Mock<ICreateApiHttpClient> _mockHttpClient;

        public TextGeneratorTest()
        {
            _mockHttpClient = new Mock<ICreateApiHttpClient>();
            _client = new CreateApiClient(_mockHttpClient.Object);
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
