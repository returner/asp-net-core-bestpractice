namespace AppBackend.Configuration.Interface
{
    public interface IAppSettings
    {
        string? Environment { get; init; }
        ISwaggerSetting? Swagger { get; init; }
        IEnumerable<string>? CorsOrigins { get; init; }
        IDatabaseSetting? Database { get; init; }
        ICacheServerSetting? CacheServer { get; init; }
    }
}
