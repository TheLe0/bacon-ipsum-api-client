using System.Threading.Tasks;

namespace Bacon.Ipsum.API.Client.Implementation
{
    public interface ITextGenerator
    {
        Task<string> GenerateSentenceAsync(int sentences);
        Task<string> GenerateParagraphAsync(int paragraphs);
    }
}
