using EVialConfig.Domain.Interfaces.Repositories;
using EVialConfig.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EVialConfig.Infra.IoC.Repository
{
    internal class ExtensionRepository
    {
        internal static void Provide(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITypeTrafficViolationRepository, TypeTrafficViolationRepository>();
            serviceCollection.AddScoped<ITypeTrafficViolationCacheRepository, TypeTrafficViolationCacheRepository>();
        }
    }
}
