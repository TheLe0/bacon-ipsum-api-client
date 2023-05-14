using Create.API.Client.Configuration;
using Create.API.Client.Infraestructure;
using Create.API.Client.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Create.API.Client.Implementation
{
    public class TextGenerator : BaseApiClient, ITextGenerator
    {
        public TextGenerator() : base() { }
        public TextGenerator(string baseUrl) : base(baseUrl) { }
        public TextGenerator(CreateApiClientConfiguration configuration) : base(configuration) { }
        public TextGenerator(ICreateApiHttpClient restApiClient) : base(restApiClient) { }

        public async Task<string> GenerateSentenceAsync(int sentences)
        {
            if (sentences <= 0) return string.Empty;

            Endpoint.SetQueryParam(Parameters.Sentences, sentences);
            SetupDefaultParameters();

            var generatedText = await GetAsync<IEnumerable<string>>()
                .ConfigureAwait(false);

            if (generatedText == null) return string.Empty;

            return generatedText.FirstOrDefault();
        }

        public async Task<string> GenerateParagraphAsync(int paragraphs)
        {
            if (paragraphs <= 0) return string.Empty;

            Endpoint.SetQueryParam(Parameters.Paragraph, paragraphs);
            SetupDefaultParameters();

            var generatedText = await GetAsync<IEnumerable<string>>()
                .ConfigureAwait(false);

            if (generatedText == null) return string.Empty;

            return generatedText.FirstOrDefault();
        }

        private void SetupDefaultParameters()
        {
            Endpoint.SetQueryParam(Parameters.Type, "meat-and-fille");
            Endpoint.SetQueryParam(Parameters.Format, "json");
        }
    }
}
