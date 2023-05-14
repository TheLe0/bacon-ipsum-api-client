using RestSharp;
using System.Threading.Tasks;

namespace Create.API.Client.Infraestructure
{
    public interface ICreateApiHttpClient
    {
        Task<T> GetAsync<T>(RestRequest request);
        string GetBaseUrl();
    }
}
