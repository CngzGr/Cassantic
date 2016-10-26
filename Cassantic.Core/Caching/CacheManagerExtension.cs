using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Caching
{
    public static class CacheManagerExtension
    {
        public static T Get<T>(this ICacheManager cacheManager,string key, Func<T> action)
        {
            if (cacheManager.IsCache(key))
                return cacheManager.Get<T>(key);
            else
            {
                var data=action();
                cacheManager.Set<T>(key, data);
                return data;
            }
        }

        public static T Get<T>(this ICacheManager cacheManager, string key,int expiredTime, Func<T> action)
        {
            if (cacheManager.IsCache(key))
                return cacheManager.Get<T>(key);
            else
            {
                var data = action();
                cacheManager.Set<T>(key, data);
                return data;
            }
        }
    }
}
