using EVialConfig.Application.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace EVialConfig.Infra.IoC.Mapper
{
    internal class ExtensionMapper
    {
        internal static void Provide(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(new[] { typeof(TypeTrafficViolationMappingProfile).Assembly });
        }
    }
}
