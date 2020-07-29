using CSharp.ApiRequest.Library.Structure.Interfaces;
using System.Net.Http;

namespace CSharp.ApiRequest.Library.Builders.Interfaces
{
    public interface IHttpClientBuilder
    {
        HttpClient Create(IRequestInfo requestInfo);
    }
}
