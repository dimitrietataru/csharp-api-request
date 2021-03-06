﻿using CSharp.ApiRequest.Library.Builders.Interfaces;
using CSharp.ApiRequest.Library.Factories.Interfaces;
using CSharp.ApiRequest.Library.Structure.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.ApiRequest.Library
{
    public sealed class HttpClientRequest : IHttpClientRequest
    {
        private readonly IHttpClientBuilder httpClientBuilder;
        private readonly ICancellationTokenFactory cancellationTokenFactory;

        public HttpClientRequest(
            IHttpClientBuilder httpClientBuilder,
            ICancellationTokenFactory cancellationTokenFactory)
        {
            this.httpClientBuilder = httpClientBuilder;
            this.cancellationTokenFactory = cancellationTokenFactory;
        }

        public async Task GetAsync(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.GetAsync(info.Url, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task<TResult> GetAsync<TResult>(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.GetAsync(info.Url, cancellationToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(cancellationToken);
        }

        public async Task<TResult> GetAsync<TRequest, TResult>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var request = new HttpRequestMessage(HttpMethod.Get, info.Url)
            {
                Content = new StringContent(
                    content: JsonConvert.SerializeObject(body),
                    encoding: Encoding.Default,
                    mediaType: "application/json")
            };

            var response = await client.SendAsync(request, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }

        public async Task PostAsync(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.PostAsync(info.Url, null, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task PostAsync<TRequest>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.PostAsJsonAsync(info.Url, body, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task<TResult> PostAsync<TResult>(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.PostAsync(info.Url, null, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }

        public async Task<TResult> PostAsync<TRequest, TResult>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.PostAsJsonAsync(info.Url, body, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }

        public async Task PutAsync(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.PutAsync(info.Url, null, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task PutAsync<TRequest>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.PutAsJsonAsync(info.Url, body, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task<TResult> PutAsync<TResult>(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.PutAsync(info.Url, null, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }

        public async Task<TResult> PutAsync<TRequest, TResult>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.PutAsJsonAsync(info.Url, body, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }

        public async Task PatchAsync(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var request = new HttpRequestMessage(HttpMethod.Patch, info.Url);

            var response = await client.SendAsync(request, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task PatchAsync<TRequest>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var request = new HttpRequestMessage(HttpMethod.Patch, info.Url)
            {
                Content = new StringContent(
                    content: JsonConvert.SerializeObject(body),
                    encoding: Encoding.Default,
                    mediaType: "application/json")
            };

            var response = await client.SendAsync(request, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task<TResult> PatchAsync<TResult>(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var request = new HttpRequestMessage(HttpMethod.Patch, info.Url);

            var response = await client.SendAsync(request, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }

        public async Task<TResult> PatchAsync<TRequest, TResult>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var request = new HttpRequestMessage(HttpMethod.Patch, info.Url)
            {
                Content = new StringContent(
                    content: JsonConvert.SerializeObject(body),
                    encoding: Encoding.Default,
                    mediaType: "application/json")
            };

            var response = await client.SendAsync(request, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }

        public async Task DeleteAsync(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.DeleteAsync(info.Url, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync<TRequest>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var request = new HttpRequestMessage(HttpMethod.Delete, info.Url)
            {
                Content = new StringContent(
                    content: JsonConvert.SerializeObject(body),
                    encoding: Encoding.Default,
                    mediaType: "application/json")
            };

            var response = await client.SendAsync(request, linkedToken);
            response.EnsureSuccessStatusCode();
        }

        public async Task<TResult> DeleteAsync<TResult>(
            IRequestInfo info, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var response = await client.DeleteAsync(info.Url, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }

        public async Task<TResult> DeleteAsync<TRequest, TResult>(
            IRequestInfo info, TRequest body, CancellationToken cancellationToken = default)
        {
            using var client = httpClientBuilder.Create(info);
            var linkedToken = cancellationTokenFactory.Create(cancellationToken, info.Timeout);

            var request = new HttpRequestMessage(HttpMethod.Delete, info.Url)
            {
                Content = new StringContent(
                    content: JsonConvert.SerializeObject(body),
                    encoding: Encoding.Default,
                    mediaType: "application/json")
            };

            var response = await client.SendAsync(request, linkedToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResult>(linkedToken);
        }
    }
}
