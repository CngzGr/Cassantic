using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Infrastructure
{
    public interface IEngine
    {
        void Initialize();
        ContainerManager ContainerManaer { get; }
        T Resolve<T>() where T : class;
        object Resolve(Type type);
        T[] ResolveAll<T>();


    }
}
