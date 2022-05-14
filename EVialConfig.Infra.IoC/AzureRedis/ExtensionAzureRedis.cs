using EVialConfig.Infra.Data.Connection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EVialConfig.Infra.IoC.AzureRedis
{
    internal class ExtensionAzureRedis
    {
        internal static void Provide(IServiceCollection serviceCollection, IConfiguration configuration)
        {
           serviceCollection.AddSingleton(async x => await RedisConnection.InitializeAsync(configuration["CacheConnection"].ToString()));
        }
    }
}
