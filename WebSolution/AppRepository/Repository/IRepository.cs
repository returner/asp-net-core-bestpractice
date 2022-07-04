using AppEntities.interfaces;
using Ardalis.Specification;

namespace AppRepository.Repository
{
    public interface IRepository<T> : IRepositoryBase<T> where T : class, IEntityAggreateRoot
    {

    }
}
