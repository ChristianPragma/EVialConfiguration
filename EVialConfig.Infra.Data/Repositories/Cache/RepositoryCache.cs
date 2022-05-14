using EVialConfig.Domain.Interfaces.Repositories;
using EVialConfig.Infra.Data.Connection;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using System.Text.Json;

namespace EVialConfig.Infra.Data.Repositories
{
    public class RepositoryCache<T> : IRepositoryCache<T> where T : class
    {
        //private readonly IDistributedCache _distributedCache;
        //private readonly RedisConnection _redisConnection;
        private readonly Task<RedisConnection> _redisConnectionFactory;
        private RedisConnection _redisConnection;


        //public RepositoryCache(IDistributedCache distributedCache) {
        //    _distributedCache = distributedCache;
        //}

        public RepositoryCache(Task<RedisConnection> redisConnectionFactory)
        {
            _redisConnectionFactory = redisConnectionFactory;
        }

        public async Task<T> Get(string key)
        {
            _redisConnection = await _redisConnectionFactory;
            T result;
            var data = await _redisConnection.BasicRetryAsync(async (db) => await db.StringGetAsync(key));
            result = JsonSerializer.Deserialize<T>(json: data.ToString());

            //byte[] data= await _distributedCache.GetAsync(key);
            //result = JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(data));
            return result;
        }

        public async Task<IEnumerable<T>> GetListAsync(string key)
        {
            _redisConnection = await _redisConnectionFactory;
            IEnumerable<T> result;
            var data = await _redisConnection.BasicRetryAsync(async (db) => await db.StringGetAsync(key));
            result = JsonSerializer.Deserialize<IEnumerable<T>>(json: data.ToString());
            return result;
        }

        public void Refresh(string key)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new NotImplementedException();
        }

        public async Task Set(string key, T value) 
        {
            _redisConnection = await _redisConnectionFactory;
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string dataString = JsonSerializer.Serialize(value, options);
            var result = await _redisConnection.BasicRetryAsync( async (db) => await db.StringSetAsync(key, dataString) );
            //_distributedCache.SetAsync(key, Encoding.UTF8.GetBytes(dataString));

        }
    }
}
