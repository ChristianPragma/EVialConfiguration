using EVialConfig.Infra.IoC.AzureRedis;
using EVialConfig.Infra.IoC.Context;
using EVialConfig.Infra.IoC.Mapper;
using EVialConfig.Infra.IoC.Mediatr;
using EVialConfig.Infra.IoC.Repository;
using EVialConfig.Infra.IoC.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EVialConfig.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            ExtensionAzureRedis.Provide(services, configuration);
            ExtensionDB.Provide(services, configuration);
            ExtensionMapper.Provide(services);
            ExtensionRepository.Provide(services);
            ExtensionMediatr.Provide(services);
            ExtensionService.Provide(services);
        }
    }
}
