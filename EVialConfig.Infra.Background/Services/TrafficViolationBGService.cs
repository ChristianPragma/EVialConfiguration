using EVialConfig.Infra.Background.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVialConfig.Infra.Background.Services
{
    public class TrafficViolationBGService : ITrafficViolationBGService
    {
        public TrafficViolationBGService()
        {

        }

        public Task DoWork(CancellationToken stoppingToken)
        {
            // Seter valores en redis
            throw new NotImplementedException();
        }
    }
}
