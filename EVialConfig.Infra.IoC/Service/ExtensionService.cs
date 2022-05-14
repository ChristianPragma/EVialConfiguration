using EVialConfig.Application.Services;
using EVialConfig.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EVialConfig.Infra.IoC.Service
{
    internal class ExtensionService
    {
        internal static void Provide(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITypeTrafficViolationService, TypeTrafficViolationService>();
        }
    }
}
