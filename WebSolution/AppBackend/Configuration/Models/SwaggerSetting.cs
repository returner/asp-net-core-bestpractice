using AppBackend.Configuration.Interface;

namespace AppBackend.Configuration.Models
{
    public record SwaggerSetting : ISwaggerSetting
    {
        public string? Title { get; init; }
        public string? Version { get; init; }
        public string? Description { get; init; }
        public string? Link { get; init; }
    }

}
