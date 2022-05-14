using EVialConfig.Application.Handlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EVialConfig.Infra.IoC.Mediatr
{
    internal class ExtensionMediatr
    {
        internal static void Provide(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(new[] { typeof(GetTypeTrafficViolationHandler).Assembly });
        }
    }
}
