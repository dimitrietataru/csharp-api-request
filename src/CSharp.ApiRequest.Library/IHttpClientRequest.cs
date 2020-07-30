using CSharp.ApiRequest.Library.Structure.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.ApiRequest.Library
{
    public interface IHttpClientRequest
    {
        Task GetAsync(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task<TResult> GetAsync<TResult>(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task<TResult> GetAsync<TRequest, TResult>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);

        Task PostAsync(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task PostAsync<TRequest>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);
        Task<TResult> PostAsync<TResult>(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task<TResult> PostAsync<TRequest, TResult>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);

        Task PutAsync(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task PutAsync<TRequest>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);
        Task<TResult> PutAsync<TResult>(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task<TResult> PutAsync<TRequest, TResult>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);

        Task PatchAsync(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task PatchAsync<TRequest>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);
        Task<TResult> PatchAsync<TResult>(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task<TResult> PatchAsync<TRequest, TResult>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);

        Task DeleteAsync(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task DeleteAsync<TRequest>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);
        Task<TResult> DeleteAsync<TResult>(IRequestInfo requestInfo, CancellationToken cancellationToken = default);
        Task<TResult> DeleteAsync<TRequest, TResult>(IRequestInfo requestInfo, TRequest body, CancellationToken cancellationToken = default);
    }
}
