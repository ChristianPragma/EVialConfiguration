namespace EVialConfig.Domain.Interfaces.Repositories
{
    public interface IRepositoryCache<T> where T : class
    {
        public Task<T> Get(string key);
        public Task<IEnumerable<T>> GetListAsync(string key);
        public void Refresh(string key);
        public void Remove(string key);
        public void RemoveAll();
        public Task Set(string key, T value);
        //public void Set(string key, byte[] value, Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions options);
    }
}
