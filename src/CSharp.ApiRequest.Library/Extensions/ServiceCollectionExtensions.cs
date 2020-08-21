using CSharp.ApiRequest.Library.Factories;
using CSharp.ApiRequest.Library.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CSharp.ApiRequest.Library.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCommunicationDependencies(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddScoped<Builders.Interfaces.IHttpClientBuilder, Builders.HttpClientBuilder>();
            services.AddScoped<ICancellationTokenFactory, CancellationTokenFactory>();
            services.AddScoped<IHttpClientRequest, HttpClientRequest>();

            return services;
        }
    }
}
