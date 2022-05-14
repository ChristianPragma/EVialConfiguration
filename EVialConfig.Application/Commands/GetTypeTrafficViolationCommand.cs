using EVialConfig.Domain.Dtos;
using MediatR;

namespace EVialConfig.Application.Commands
{
    public class GetTypeTrafficViolationCommand : IRequest<IEnumerable<GetTypeTrafficViolationResponseDto>>
    {
        public GetTypeTrafficViolationRequestDto RequestDto { get; set; }
        public GetTypeTrafficViolationCommand(GetTypeTrafficViolationRequestDto requestDto)
        {
            RequestDto = requestDto;
        }
    }
}
