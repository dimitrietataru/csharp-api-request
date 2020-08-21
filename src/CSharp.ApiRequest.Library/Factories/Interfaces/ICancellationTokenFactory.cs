using System;
using System.Threading;

namespace CSharp.ApiRequest.Library.Factories.Interfaces
{
    public interface ICancellationTokenFactory
    {
        CancellationToken Create(CancellationToken cancellationToken, TimeSpan timeout);
    }
}
