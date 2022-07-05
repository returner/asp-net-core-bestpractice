namespace AppBackend.Configuration.Interface
{
    public interface IDatabaseSetting
    {
        string? ConnectionString { get; init; }
        string? DatabaseName { get; init; }
        string? DbVersion { get; init; }
    }
}
