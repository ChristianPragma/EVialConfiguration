using EVialConfig.Domain.Dtos;
using MediatR;

namespace EVialConfig.Application.Commands
{
    internal class InsertTypeTrafficViolationCacheCommand : IRequest<bool> 
    {
        public InsertTypeTrafficViolationCacheDto RequestDto { get; set; }
        public InsertTypeTrafficViolationCacheCommand(InsertTypeTrafficViolationCacheDto requestDto)
        {
            RequestDto = requestDto;
        }
    }
}
