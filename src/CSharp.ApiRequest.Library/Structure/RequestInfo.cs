using CSharp.ApiRequest.Library.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CSharp.ApiRequest.Library.Structure
{
    public sealed class RequestInfo : IRequestInfo
    {
        public RequestInfo(string url, int timeout, params IRequestHeader[] headers)
        {
            Url = url;
            Auth = new RequestAuthorize();
            Timeout = timeout;
            Headers = headers.ToList();
        }

        public RequestInfo(string url, string jwt, int timeout, params IRequestHeader[] headers)
        {
            Url = url;
            Auth = new RequestAuthorize(jwt);
            Timeout = timeout;
            Headers = headers.ToList();
        }

        public string Url { get; }
        public int Timeout { get; }
        public IRequestAuthorize Auth { get; }
        public ICollection<IRequestHeader> Headers { get; } = new List<IRequestHeader>();

        public bool RequiresAuthorization()
        {
            return Auth?.WithAuthorization ?? false;
        }

        public TimeSpan GetRequestTimeout()
        {
            return new TimeSpan(0, Timeout, 0);
        }

        public CancellationToken GetCancellationToken()
        {
            return new CancellationTokenSource(GetRequestTimeout()).Token;
        }
    }
}
