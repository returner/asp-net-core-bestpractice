using AppBackend.Configuration.Interface;

namespace AppBackend.Configuration
{
    public interface IConfigurationService
    {
        IAppSettings Build();
    }
}