namespace AppBackend.Configuration.Interface
{
    public interface ICacheServerSetting
    {
        string? Name { get; init; }
        int Port { get; init; }
    }
}
