using EVialConfig.Application.Commands;
using EVialConfig.Application.Mappers;
using EVialConfig.Domain.Dtos;
using EVialConfig.Domain.Interfaces.Repositories;
using EVialConfig.Domain.Models;
using MediatR;

namespace EVialConfig.Application.Handlers
{
    public class GetTypeTrafficViolationHandler : IRequestHandler<GetTypeTrafficViolationCommand, IEnumerable<GetTypeTrafficViolationResponseDto>>
    {
        // private readonly ITypeTrafficViolationRepository _typeTrafficViolationRepository;
        private readonly ITypeTrafficViolationCacheRepository _typeTrafficViolationCacheRepository;
        public GetTypeTrafficViolationHandler(
            //ITypeTrafficViolationRepository typeTrafficViolationRepository, 
            ITypeTrafficViolationCacheRepository typeTrafficViolationCacheRepository)
        {
           // _typeTrafficViolationRepository = typeTrafficViolationRepository;
            _typeTrafficViolationCacheRepository = typeTrafficViolationCacheRepository;
        }
        public async Task<IEnumerable<GetTypeTrafficViolationResponseDto>> Handle(GetTypeTrafficViolationCommand request, CancellationToken cancellationToken)
        {
            IEnumerable<GetTypeTrafficViolationResponseDto>? result;
            //IEnumerable<TypesTrafficViolation> entities = await _typeTrafficViolationRepository.GetAllAsync();
            //IEnumerable<TypesTrafficViolation> entities = await _typeTrafficViolationCacheRepository.GetListAsync("kTypeTrafficViolation");
            TypesTrafficViolation entity = await _typeTrafficViolationCacheRepository.Get("kTypeTrafficViolation");
            result = new List<GetTypeTrafficViolationResponseDto>() { 
              new GetTypeTrafficViolationResponseDto { 
                    CodeFalta = entity.CodeFalta,
                    Amount = entity.Amount, 
                    PreventiveMeasure = entity.PreventiveMeasure,    
                    Qualification = entity.Qualification,
                    Sanction = entity.Sanction,
                    Violation = entity.Violation,
              }
            };
            //result = TypeTrafficViolationMapper.Mapper.Map<IEnumerable<GetTypeTrafficViolationResponseDto>>(entities);
            return result;
        }
    }
}
