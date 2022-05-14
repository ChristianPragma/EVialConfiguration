namespace EVialConfig.Infra.Background.Interfaces
{
    internal interface ITrafficViolationBGService
    {
        Task DoWork(CancellationToken stoppingToken);
    }
}
