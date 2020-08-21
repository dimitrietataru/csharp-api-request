using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharp.ApiRequest.Library.Structure.Interfaces
{
    public interface IRequestInfo
    {
        string Url { get; }
        TimeSpan Timeout { get; }
        IRequestAuthorize Auth { get; }
        ICollection<IRequestHeader> Headers { get; }

        bool RequiresAuthorization();
        CancellationToken GetCancellationToken();
    }
}
