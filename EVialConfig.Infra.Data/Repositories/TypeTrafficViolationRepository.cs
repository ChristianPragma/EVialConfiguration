using EVialConfig.Domain.Interfaces.Repositories;
using EVialConfig.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EVialConfig.Infra.Data.Repositories
{
    public class TypeTrafficViolationRepository : BaseRepository<TypesTrafficViolation>, ITypeTrafficViolationRepository
    {
        public TypeTrafficViolationRepository(DbContext context): base(context)
        {
        }

    }
}
