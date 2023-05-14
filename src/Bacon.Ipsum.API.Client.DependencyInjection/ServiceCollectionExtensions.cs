using Bacon.Ipsum.API.Client.Configuration;
using Bacon.Ipsum.API.Client.Infraestructure;
using Microsoft.Extensions.DependencyInjection;

namespace Bacon.Ipsum.API.Client.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBaconIpsumApiClient(this IServiceCollection services)
        {
            services.AddTransient<IBaconIpsumApiHttpClient, BaconIpsumApiHttpClient>();

            services.AddTransient<IBaconIpsumApiClient>(x =>
                new BaconIpsumApiClient(x.GetRequiredService<IBaconIpsumApiHttpClient>()));

            return services;
        }

        public static IServiceCollection AddBaconIpsumApiClient(this IServiceCollection services, string baseUrl)
        {
            services.AddTransient<IBaconIpsumApiHttpClient>(_ =>
                new BaconIpsumApiHttpClient(baseUrl));

            services.AddTransient<IBaconIpsumApiClient>(x =>
                new BaconIpsumApiClient(x.GetRequiredService<IBaconIpsumApiHttpClient>()));

            return services;
        }

        public static IServiceCollection AddBaconIpsumApiClient(this IServiceCollection services, BaconIpsumApiClientConfiguration configs)
        {
            services.AddTransient<IBaconIpsumApiHttpClient>(_ =>
                new BaconIpsumApiHttpClient(configs));

            services.AddTransient<IBaconIpsumApiClient>(x =>
                new BaconIpsumApiClient(x.GetRequiredService<IBaconIpsumApiHttpClient>()));

            return services;
        }
    }
}
