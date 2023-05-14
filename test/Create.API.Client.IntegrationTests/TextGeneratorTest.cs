using Create.API.Client.Infraestructure;

namespace Create.API.Client.IntegrationTests
{
    public class TextGeneratorTest
    {
        private readonly ICreateApiClient _client;

        public TextGeneratorTest()
        {
            _client = new CreateApiClient();
        }

        [Fact]
        public async void GenerateSentenceAsync_Success()
        {
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
        public async void GenerateParagraphAsync_Success()
        {
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
    }
}