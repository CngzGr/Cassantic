using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Infrastructure
{
    public interface ITypeFinder
    {
        IList<Assembly> GetAssembly();
        IEnumerable<Type> FindClassesOfType(Type findType, bool onlyLoadAssembly = true);
    }
}
