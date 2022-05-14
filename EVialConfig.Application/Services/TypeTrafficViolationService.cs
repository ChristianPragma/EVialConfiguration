using EVialConfig.Application.Commands;
using EVialConfig.Domain.Dtos;
using EVialConfig.Domain.Interfaces;
using MediatR;

namespace EVialConfig.Application.Services
{
    public class TypeTrafficViolationService : ITypeTrafficViolationService
    {
        private readonly IMediator _mediator;
        public TypeTrafficViolationService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IEnumerable<GetTypeTrafficViolationResponseDto>> GetTrafficViolationsAsync(GetTypeTrafficViolationRequestDto requestDto)
        {
          IEnumerable<GetTypeTrafficViolationResponseDto> result ;
          result = await _mediator.Send(new GetTypeTrafficViolationCommand(requestDto));
          return result;
        }

        public async Task InsertTypeTrafficViolationAsync(CreateTypeTrafficViolationRequestDto requestDto)
        {
            try
            {
                // Send to DB
                await _mediator.Send(new CreateTypeTrafficViolationCommand(requestDto));

                // Send to Redis
                await _mediator.Send(new InsertTypeTrafficViolationCacheCommand(new InsertTypeTrafficViolationCacheDto
                {
                    Key = "kTypeTrafficViolation",
                    Data = requestDto
                }));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
