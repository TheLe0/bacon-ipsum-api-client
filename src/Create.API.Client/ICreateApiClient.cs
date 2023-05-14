using Create.API.Client.Implementation;

namespace Create.API.Client
{
    public interface ICreateApiClient
    {
        ITextGenerator TextGenerator { get; }
    }
}
