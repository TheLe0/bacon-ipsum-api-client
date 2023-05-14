using Create.API.Client.Configuration;
using Create.API.Client.Infraestructure;
using Microsoft.Extensions.DependencyInjection;

namespace Create.API.Client.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCreateApiClient(this IServiceCollection services)
        {
            services.AddTransient<ICreateApiHttpClient, CreateApiHttpClient>();

            services.AddTransient<ICreateApiClient>(x =>
                new CreateApiClient(x.GetRequiredService<ICreateApiHttpClient>()));

            return services;
        }

        public static IServiceCollection AddCreateApiClient(this IServiceCollection services, string baseUrl)
        {
            services.AddTransient<ICreateApiHttpClient>(_ =>
                new CreateApiHttpClient(baseUrl));

            services.AddTransient<ICreateApiClient>(x =>
                new CreateApiClient(x.GetRequiredService<ICreateApiHttpClient>()));

            return services;
        }

        public static IServiceCollection AddCreateApiClient(this IServiceCollection services, CreateApiClientConfiguration configs)
        {
            services.AddTransient<ICreateApiHttpClient>(_ =>
                new CreateApiHttpClient(configs));

            services.AddTransient<ICreateApiClient>(x =>
                new CreateApiClient(x.GetRequiredService<ICreateApiHttpClient>()));

            return services;
        }
    }
}
