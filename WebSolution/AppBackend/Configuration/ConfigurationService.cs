using AppBackend.Configuration.Interface;
using AppBackend.Configuration.Models;

namespace AppBackend.Configuration
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration _configuration;

        public ConfigurationService(EnvironmentType environmentType, string? currentDirectory = null)
        {
            var environmentVariableName = environmentType switch
            {
                EnvironmentType.AspNetCore => EnvironmentVariable.AspnetCore,
                EnvironmentType.Dotnet => EnvironmentVariable.Dotnet,
                _ => EnvironmentVariable.AspnetCore
            };

            _configuration = new ConfigurationBuilder()
                .SetBasePath(currentDirectory ?? Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{environmentVariableName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }
        private T GetConfigurationValue<T>(string key) => _configuration.GetSection($"AppSettings:{key}").Get<T>();

        public IAppSettings Build()
        {
            var appsettings = new AppSettings
            {
                Environment = GetConfigurationValue<string>("Environment"),
                CorsOrigins = GetConfigurationValue<IEnumerable<string>>("CorsOrigins"),

                Swagger = new SwaggerSetting
                {
                    Title = GetConfigurationValue<string>("Swagger:Title"),
                    Version = GetConfigurationValue<string>("Swagger:Version"),
                    Description = GetConfigurationValue<string>("Swagger:Description"),
                    Link = GetConfigurationValue<string>("Swagger:Link"),
                },
                Database = new DatabaseSetting
                {
                    ConnectionString = GetConfigurationValue<string>("Database:ConnectionString"),
                    DatabaseName = GetConfigurationValue<string>("Database:DatabaseName"),
                },
                CacheServer = new CacheServerSetting
                {
                    Name = GetConfigurationValue<string>("CacheServer:Name"),
                    Port = GetConfigurationValue<int>("CacheServer:Port"),
                }
            };

            return appsettings;
        }
    }
}