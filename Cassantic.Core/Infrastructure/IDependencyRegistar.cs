using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Infrastructure
{
    public interface IDependencyRegistar
    {
        void Register(ContainerBuilder builder, ITypeFinder typeFinder);
    }
}
