using AppCore;
using AppRepository.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AppBusinessCore
{
    public static class ServiceRegister
    {
        public static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(AppRepository<>));
            services.AddScoped(typeof(IReadRepository<>), typeof(AppRepository<>));
        }
    }
}
