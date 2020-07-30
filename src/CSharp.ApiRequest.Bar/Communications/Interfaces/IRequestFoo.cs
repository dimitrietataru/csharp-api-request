using CSharp.ApiRequest.Bar.Communications.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.ApiRequest.Bar.Communications.Interfaces
{
    public interface IRequestFoo
    {
        Task<ResponseDto> GetWithResponseAsync(CancellationToken cancellationToken = default);
        Task GetWithoutResponseAsync(CancellationToken cancellationToken = default);

        Task<ResponseDto> PostWithBodyAndWithReponseAsync(RequestDto dto, CancellationToken cancellationToken = default);
        Task PostWithBodyAndWithoutReponseAsync(RequestDto dto, CancellationToken cancellationToken = default);
        Task<ResponseDto> PostWithoutBodyAndWithReponseAsync(CancellationToken cancellationToken = default);
        Task PostWithoutBodyAndWithoutReponseAsync(CancellationToken cancellationToken = default);

        Task<ResponseDto> PutWithBodyAndWithReponseAsync(RequestDto dto, CancellationToken cancellationToken = default);
        Task PutWithBodyAndWithoutReponseAsync(RequestDto dto, CancellationToken cancellationToken = default);
        Task<ResponseDto> PutWithoutBodyAndWithReponseAsync(CancellationToken cancellationToken = default);
        Task PutWithoutBodyAndWithoutReponseAsync(CancellationToken cancellationToken = default);

        Task<ResponseDto> PatchWithBodyAndWithReponseAsync(RequestDto dto, CancellationToken cancellationToken = default);
        Task PatchWithBodyAndWithoutReponseAsync(RequestDto dto, CancellationToken cancellationToken = default);
        Task<ResponseDto> PatchWithoutBodyAndWithReponseAsync(CancellationToken cancellationToken = default);
        Task PatchWithoutBodyAndWithoutReponseAsync(CancellationToken cancellationToken = default);

        Task<ResponseDto> DeleteWithResponseAsync(CancellationToken cancellationToken = default);
        Task DeleteWithoutResponseAsync(CancellationToken cancellationToken = default);
    }
}
