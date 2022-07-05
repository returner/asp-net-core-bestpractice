using AppBackend.Configuration.Interface;

namespace AppBackend.Configuration.Models
{
    public record AppSettings : IAppSettings
    {
        public string? Environment { get; init; }
        public ISwaggerSetting? Swagger { get; init; }
        public IEnumerable<string>? CorsOrigins { get; init; }
        public IDatabaseSetting? Database { get; init; }
        public ICacheServerSetting? CacheServer { get; init; }
    }
}
