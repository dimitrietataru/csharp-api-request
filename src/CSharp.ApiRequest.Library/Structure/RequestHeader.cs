using CSharp.ApiRequest.Library.Structure.Interfaces;

namespace CSharp.ApiRequest.Library.Structure
{
    public sealed class RequestHeader : IRequestHeader
    {
        public RequestHeader(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public string Value { get; }
    }
}
