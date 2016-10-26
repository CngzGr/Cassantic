using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Caching
{
    public class RedisCacheManager:ICacheManager
    {
        private readonly IRedisClientsManager redisManager;
        public RedisCacheManager(IRedisClientsManager _redisManager)
        {
            this.redisManager = _redisManager;
        }
        public T Get<T>(string key)
        {
          var client=  redisManager.GetClient();
          return client.Get<T>(key);
        }
        public void Set<T>(string key, T value)
        {
            using (var client = redisManager.GetClient())
            {
               client.Set<T>(key,value);
            }
        }
        public void Set<T>(string key, T value, int expiredTime)
        {
            using (var client = redisManager.GetClient())
            {
                client.Set<T>(key, value, DateTime.Now.AddMinutes(expiredTime));
            }
        }

        public bool IsCache(string key)
        {
            using (var client = redisManager.GetClient())
            {
             return   client.ContainsKey(key);
            }
        }

        public void Remove<T>(string key)
        {
            using (var client = redisManager.GetClient())
            {
                client.Remove(key);
            }
        }

        public void Clear()
        {
            using (var client = redisManager.GetClient())
            {
                client.RemoveAll(client.GetAllKeys());
            }
        }
    }
}
