using CSharp.ApiRequest.Library.Builders.Interfaces;
using CSharp.ApiRequest.Library.Structure.Interfaces;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CSharp.ApiRequest.Library.Builders
{
    public sealed class HttpClientBuilder : IHttpClientBuilder
    {
        public HttpClient Create([NotNull] IRequestInfo requestInfo)
        {
            var client = new HttpClient(); // TODO: Use IHttpClientFactory

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (requestInfo.RequiresAuthorization())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    scheme: "Bearer",
                    parameter: requestInfo.Auth.JsonWebToken);
            }

            foreach (var header in requestInfo.Headers)
            {
                client.DefaultRequestHeaders.Add(header.Name, header.Value);
            }

            client.Timeout = requestInfo.GetRequestTimeout();

            return client;
        }
    }
}
