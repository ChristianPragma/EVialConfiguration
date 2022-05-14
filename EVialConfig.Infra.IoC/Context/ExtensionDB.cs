using EVialConfig.Infra.Data.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EVialConfig.Infra.IoC.Context
{
    internal class ExtensionDB
    {
        internal static void Provide(IServiceCollection serviceCollection, IConfiguration configurationManager)
        {
            serviceCollection.AddScoped<DbContext, ConfigContext>();
            serviceCollection.AddDbContext<ConfigContext>(options => options.UseSqlServer(configurationManager.GetConnectionString("DbConnectionString")));
        }
    }
}
