using CSharp.ApiRequest.Library.Structure.Interfaces;

namespace CSharp.ApiRequest.Library.Structure
{
    public sealed class RequestAuthorize : IRequestAuthorize
    {
        public RequestAuthorize()
        {
        }

        public RequestAuthorize(string jsonWebToken)
        {
            JsonWebToken = jsonWebToken;
            WithAuthorization = true;
        }

        public bool WithAuthorization { get; } = false;
        public string JsonWebToken { get; }
    }
}
