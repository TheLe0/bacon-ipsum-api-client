using Bacon.Ipsum.API.Client.Implementation;

namespace Bacon.Ipsum.API.Client
{
    public interface IBaconIpsumApiClient
    {
        ITextGenerator TextGenerator { get; }
    }
}
