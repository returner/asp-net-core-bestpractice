using AppBackend.Configuration.Interface;

namespace AppBackend.Configuration.Models
{
    public class CacheServerSetting : ICacheServerSetting
    {
        public string? Name {get; init;}
        public int Port { get; init; }
    }
}
