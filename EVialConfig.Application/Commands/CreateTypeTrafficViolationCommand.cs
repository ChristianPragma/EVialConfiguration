using EVialConfig.Domain.Dtos;
using MediatR;

namespace EVialConfig.Application.Commands
{
    public class CreateTypeTrafficViolationCommand : IRequest<bool>
    {
        public CreateTypeTrafficViolationRequestDto RequestDto { get; set; }
        public CreateTypeTrafficViolationCommand(CreateTypeTrafficViolationRequestDto requestDto)
        {
            RequestDto = requestDto;
        }
    }
}
