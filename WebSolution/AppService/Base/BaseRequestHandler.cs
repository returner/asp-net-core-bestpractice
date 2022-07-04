using MediatR;
using Microsoft.Extensions.Logging;

namespace AppService.Base
{
    public abstract class BaseRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        public readonly ILogger<BaseRequestHandler<TRequest, TResponse>> _logger;
        public BaseRequestHandler(ILogger<BaseRequestHandler<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
