using EVialConfig.Infra.Background.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVialConfig.Infra.Background.Services
{
    internal class TrafficViolationHostedService : BackgroundService
    {
        public IServiceProvider Services { get; }
        public TrafficViolationHostedService(IServiceProvider services) {
                Services = services;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await DoWork(stoppingToken);
        }

        private async Task DoWork(CancellationToken stoppingToken)
        {
            using (var scope = Services.CreateScope())
            {
                var scopedProcessingService =
                    scope.ServiceProvider
                        .GetRequiredService<ITrafficViolationBGService>();

                await scopedProcessingService.DoWork(stoppingToken);
            }
        }
    }
}
