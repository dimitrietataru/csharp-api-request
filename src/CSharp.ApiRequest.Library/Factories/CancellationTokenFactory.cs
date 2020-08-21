using CSharp.ApiRequest.Library.Factories.Interfaces;
using System;
using System.Threading;

namespace CSharp.ApiRequest.Library.Factories
{
    public sealed class CancellationTokenFactory : ICancellationTokenFactory
    {
        public CancellationToken Create(CancellationToken cancellationToken, TimeSpan timeout)
        {
            return CancellationTokenSource
                .CreateLinkedTokenSource(
                    token1: cancellationToken,
                    token2: new CancellationTokenSource(timeout).Token)
                .Token;
        }
    }
}
