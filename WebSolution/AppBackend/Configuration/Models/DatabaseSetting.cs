using AppBackend.Configuration.Interface;

namespace AppBackend.Configuration.Models
{
    public record DatabaseSetting : IDatabaseSetting
    {
        public string? ConnectionString { get; init; }
        public string? DatabaseName { get; init; }
        public string? DbVersion { get; init; }
    }

}
