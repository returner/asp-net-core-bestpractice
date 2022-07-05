using AppBackend.Configuration.Interface;

namespace AppBackend.Configuration
{
    public interface IAppSettingsConfigurationBuilder
    {
        IAppSettings Build();
    }
}