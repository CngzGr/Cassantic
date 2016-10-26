using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Service.Common
{
    public class SubscriptionService:ISubscriptionService
    {
        public IList<IConsumer<T>> GetConsumers<T>()
        {
            return Cassantic.Core.Infrastructure.EngineManager.Current.ResolveAll<IConsumer<T>>();
        }
    }
}
