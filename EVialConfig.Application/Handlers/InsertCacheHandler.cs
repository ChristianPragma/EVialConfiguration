using EVialConfig.Application.Commands;
using EVialConfig.Application.Mappers;
using EVialConfig.Domain.Interfaces.Repositories;
using EVialConfig.Domain.Models;
using MediatR;

namespace EVialConfig.Application.Handlers
{
    internal class InsertCacheHandler<T> : IRequestHandler<InsertCacheCommand<T>, bool> where T : class
    {
        private readonly ITypeTrafficViolationCacheRepository _typeTrafficViolationCacheRepository;
        public InsertCacheHandler(ITypeTrafficViolationCacheRepository typeTrafficViolationCacheRepository)
        {
            _typeTrafficViolationCacheRepository = typeTrafficViolationCacheRepository;
        }

        public async Task<bool> Handle(InsertCacheCommand<T> request, CancellationToken cancellationToken)
        {
            bool result = false;
            TypesTrafficViolation modelEntity = TypeTrafficViolationMapper.Mapper.Map<TypesTrafficViolation>(request.RequestDto.Data);
            if (modelEntity is null)
            {
                throw new ApplicationException("Issue of types of traffic violation mapper");
            }
            await _typeTrafficViolationCacheRepository.Set(request.RequestDto.Key, modelEntity);
            result = true;
            return result;
        }
    }
}
