namespace EVialConfig.Domain.Dtos
{
    public class GetTypeTrafficViolationResponseDto
    {
        public string CodeFalta { get; set; } = null!;
        public string? Violation { get; set; }
        public string? Qualification { get; set; }
        public decimal? Amount { get; set; }
        public string? Sanction { get; set; }
        public string? PreventiveMeasure { get; set; }
    }
}
