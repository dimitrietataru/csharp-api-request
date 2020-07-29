using CSharp.ApiRequest.Library.Builders;
using CSharp.ApiRequest.Library.Builders.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CSharp.ApiRequest.Library.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCommunicationDependencies(this IServiceCollection services)
        {
            services.AddScoped<IHttpClientBuilder, HttpClientBuilder>();
            services.AddScoped<IHttpClientRequest, HttpClientRequest>();

            return services;
        }
    }
}
