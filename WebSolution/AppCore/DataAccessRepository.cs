using AppEntities;
using AppEntities.interfaces;
using AppRepository.Repository;
using Ardalis.Specification.EntityFrameworkCore;

namespace AppCore
{
    public class AppRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IEntityAggreateRoot
    {
        public AppRepository(AppDbContext context) : base(context)
        {

        }
    }
}
