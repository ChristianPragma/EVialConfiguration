using EVialConfig.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EVialConfig.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<T> AddAsync(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            IReadOnlyList<T> result = await _context.Set<T>().ToListAsync();
            return result;
        }
    }
}
