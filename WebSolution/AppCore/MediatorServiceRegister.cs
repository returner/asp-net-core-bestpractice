using AppService;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace AppBusinessCore
{
    public static class MediatorServiceRegister
    {
        public static void AddAppServiceMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(AppServiceBootstraper));
        }
    }
}
