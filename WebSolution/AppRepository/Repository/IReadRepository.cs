using AppEntities.interfaces;
using Ardalis.Specification;

namespace AppRepository.Repository
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IEntityAggreateRoot
    {
    }
}
