using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharp.ApiRequest.Library.Structure.Interfaces
{
    public interface IRequestInfo
    {
        string Url { get; }
        int Timeout { get; }
        IRequestAuthorize Auth { get; }
        ICollection<IRequestHeader> Headers { get; }

        bool RequiresAuthorization();
        TimeSpan GetRequestTimeout();
        CancellationToken GetCancellationToken();
    }
}
