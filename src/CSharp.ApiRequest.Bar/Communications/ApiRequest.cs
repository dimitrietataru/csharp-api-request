using CSharp.ApiRequest.Bar.Communications.Dtos;
using CSharp.ApiRequest.Bar.Communications.Interfaces;
using CSharp.ApiRequest.Library;
using CSharp.ApiRequest.Library.Structure;
using Microsoft.Extensions.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.ApiRequest.Bar.Communications
{
    public sealed class ApiRequest : IApiRequest, IRequestFoo
    {
        private readonly IHttpClientRequest httpRequest;
        private readonly IConfiguration configuration;

        public ApiRequest(IHttpClientRequest httpRequest, IConfiguration configuration)
        {
            this.httpRequest = httpRequest;
            this.configuration = configuration;
        }

        public IRequestFoo Foo => this;

        async Task<ResponseDto> IRequestFoo.GetWithResponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Get:WithResponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            return await httpRequest.GetAsync<ResponseDto>(requestInfo, cancellationToken);
        }

        async Task IRequestFoo.GetWithoutResponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Get:WithoutResponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            await httpRequest.GetAsync(requestInfo, cancellationToken);
        }

        async Task<ResponseDto> IRequestFoo.PostWithBodyAndWithReponseAsync(
            RequestDto dto, CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Post:WithBodyAndWithReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            return await httpRequest.PostAsync<RequestDto, ResponseDto>(requestInfo, dto, cancellationToken);
        }

        async Task IRequestFoo.PostWithBodyAndWithoutReponseAsync(
            RequestDto dto, CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Post:WithBodyAndWithoutReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            await httpRequest.PostAsync<RequestDto>(requestInfo, dto, cancellationToken);
        }

        async Task<ResponseDto> IRequestFoo.PostWithoutBodyAndWithReponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Post:WithoutBodyAndWithReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            return await httpRequest.PostAsync<ResponseDto>(requestInfo, cancellationToken);
        }

        async Task IRequestFoo.PostWithoutBodyAndWithoutReponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Post:WithoutBodyAndWithoutReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            await httpRequest.PostAsync(requestInfo, cancellationToken);
        }

        async Task<ResponseDto> IRequestFoo.PutWithBodyAndWithReponseAsync(
            RequestDto dto, CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Put:WithBodyAndWithReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            return await httpRequest.PutAsync<RequestDto, ResponseDto>(requestInfo, dto, cancellationToken);
        }

        async Task IRequestFoo.PutWithBodyAndWithoutReponseAsync(
            RequestDto dto, CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Put:WithBodyAndWithoutReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            await httpRequest.PutAsync<RequestDto>(requestInfo, dto, cancellationToken);
        }

        async Task<ResponseDto> IRequestFoo.PutWithoutBodyAndWithReponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Put:WithoutBodyAndWithReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            return await httpRequest.PutAsync<ResponseDto>(requestInfo, cancellationToken);
        }

        async Task IRequestFoo.PutWithoutBodyAndWithoutReponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Put:WithoutBodyAndWithoutReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            await httpRequest.PutAsync(requestInfo, cancellationToken);
        }

        async Task<ResponseDto> IRequestFoo.PatchWithBodyAndWithReponseAsync(
            RequestDto dto, CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Patch:WithBodyAndWithReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            return await httpRequest.PatchAsync<RequestDto, ResponseDto>(requestInfo, dto, cancellationToken);
        }

        async Task IRequestFoo.PatchWithBodyAndWithoutReponseAsync(
            RequestDto dto, CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Patch:WithBodyAndWithoutReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            await httpRequest.PatchAsync<RequestDto>(requestInfo, dto, cancellationToken);
        }

        async Task<ResponseDto> IRequestFoo.PatchWithoutBodyAndWithReponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Patch:WithoutBodyAndWithReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            return await httpRequest.PatchAsync<ResponseDto>(requestInfo, cancellationToken);
        }

        async Task IRequestFoo.PatchWithoutBodyAndWithoutReponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Patch:WithoutBodyAndWithoutReponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            await httpRequest.PatchAsync(requestInfo, cancellationToken);
        }

        async Task<ResponseDto> IRequestFoo.DeleteWithResponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Delete:WithResponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            return await httpRequest.DeleteAsync<ResponseDto>(requestInfo, cancellationToken);
        }

        async Task IRequestFoo.DeleteWithoutResponseAsync(
            CancellationToken cancellationToken)
        {
            string url = configuration["Foo:Delete:WithoutResponse"];
            var requestInfo = new RequestInfo(url, timeout: 3);

            await httpRequest.DeleteAsync(requestInfo, cancellationToken);
        }
    }
}
