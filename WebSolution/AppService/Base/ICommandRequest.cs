using MediatR;

namespace AppService.Base
{
    /// <summary>
    /// Marker interface to present a command request
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommandRequest<T> : IRequest<T>
    {
    }
}
