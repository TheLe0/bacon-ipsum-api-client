using RestSharp;
using System.Threading.Tasks;

namespace Bacon.Ipsum.API.Client.Infraestructure
{
    public interface IBaconIpsumApiHttpClient
    {
        Task<T> GetAsync<T>(RestRequest request);
        string GetBaseUrl();
    }
}
