using EVialConfig.Domain.Dtos;

namespace EVialConfig.Domain.Interfaces
{
    public interface ITypeTrafficViolationService
    {
        public Task<IEnumerable<GetTypeTrafficViolationResponseDto>> GetTrafficViolationsAsync(GetTypeTrafficViolationRequestDto requestDto);
        public Task InsertTypeTrafficViolationAsync(CreateTypeTrafficViolationRequestDto requestDto);
    }
}
