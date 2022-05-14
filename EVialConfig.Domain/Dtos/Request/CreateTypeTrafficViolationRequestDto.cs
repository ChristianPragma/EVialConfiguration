namespace EVialConfig.Domain.Dtos
{
    // https://www.sat.gob.pe/websitev8/modulos/contenidos/mult_Papeletas_ti_rntv2.aspx
    public class CreateTypeTrafficViolationRequestDto
    {
        public string CodeFalta { get; set; } = null!;
        public string? Violation { get; set; }
        public string? Qualification { get; set; }
        public decimal? Amount { get; set; }
        public string? Sanction { get; set; }
        public string? PreventiveMeasure { get; set; }
    }
}
