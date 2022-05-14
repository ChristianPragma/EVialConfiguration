namespace EVialConfig.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        //Task<IReadOnlyList<T>> GetManyAsync();
        //Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        //Task UpdateAsync(T entity);
        //Task DeleteAsync(T entity);
    }
}
