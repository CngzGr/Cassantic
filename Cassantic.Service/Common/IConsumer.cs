using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Service.Common
{
    public interface IConsumer<T>
    {
        void HandleEvent(T eventMessage);
    }
}
