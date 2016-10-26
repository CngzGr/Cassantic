using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra.Mapping;
using Cassantic.Core.Domains;

namespace Cassantic.Core.Caching
{
    public class CassandraCacheManager:ICacheManager
    {

        private readonly ISession session;
        public CassandraCacheManager(ISession _session)
        {
           
            session = _session; 
        }




        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T value)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T value, int expiredTime)
        {
            throw new NotImplementedException();
        }

        public bool IsCache(string key)
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
    
}
