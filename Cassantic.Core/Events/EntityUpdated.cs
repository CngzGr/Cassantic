using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Events
{
    public  class EntityUpdated<T> where T:IBaseEntity
    {
        public EntityUpdated(T item)
        {
            this.Entity = item;
        }
        public T Entity { get; private set; }
    }
}
