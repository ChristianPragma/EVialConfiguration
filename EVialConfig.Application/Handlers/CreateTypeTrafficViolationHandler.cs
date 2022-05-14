using EVialConfig.Application.Commands;
using EVialConfig.Application.Mappers;
using EVialConfig.Domain.Interfaces.Repositories;
using EVialConfig.Domain.Models;
using MediatR;

namespace EVialConfig.Application.Handlers
{
    internal class CreateTypeTrafficViolationHandler : IRequestHandler<CreateTypeTrafficViolationCommand, bool>
    {
        private readonly ITypeTrafficViolationRepository _typeTrafficViolationRepository;
        public CreateTypeTrafficViolationHandler(ITypeTrafficViolationRepository typeTrafficViolationRepository)
        {
            _typeTrafficViolationRepository = typeTrafficViolationRepository;
        }

        public async Task<bool> Handle(CreateTypeTrafficViolationCommand request, CancellationToken cancellationToken)
        {
            bool result = false;
            TypesTrafficViolation modelEntity = TypeTrafficViolationMapper.Mapper.Map<TypesTrafficViolation>(request.RequestDto);
            if (modelEntity is null)
            {
                throw new ApplicationException("Issue of types of traffic violation mapper");
            }
            modelEntity.Id = Guid.NewGuid().ToString("N");
            await _typeTrafficViolationRepository.AddAsync(modelEntity);
            result = true;
            return result;
        }
    }
}
