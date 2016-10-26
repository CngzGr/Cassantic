using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Caching
{
    public interface ICacheManager
    {
      T Get<T>(string key);
      void Set<T>(string key,T value);
      void Set<T>(string key, T value,int expiredTime);
      bool IsCache(string key);
      void Remove<T>(string key);
      void Clear();
    }
}
