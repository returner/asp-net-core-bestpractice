using MediatR;

namespace AppService.Base
{
    /// <summary>
    /// Marker interface to present a query request
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueryRequest<T> : IRequest<T>
    {
    }
}
