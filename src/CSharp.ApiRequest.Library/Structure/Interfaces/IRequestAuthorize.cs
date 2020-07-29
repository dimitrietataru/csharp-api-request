namespace CSharp.ApiRequest.Library.Structure.Interfaces
{
    public interface IRequestAuthorize
    {
        bool WithAuthorization { get; }
        string JsonWebToken { get; }
    }
}
