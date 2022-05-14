using EVialConfig.Domain.Interfaces.Repositories;
using EVialConfig.Domain.Models;
using EVialConfig.Infra.Data.Connection;

namespace EVialConfig.Infra.Data.Repositories
{
    public class TypeTrafficViolationCacheRepository : RepositoryCache<TypesTrafficViolation>, ITypeTrafficViolationCacheRepository
    {
        public TypeTrafficViolationCacheRepository(Task<RedisConnection> redisConnectionFactory) : base(redisConnectionFactory)
        {
        }
    }
}
