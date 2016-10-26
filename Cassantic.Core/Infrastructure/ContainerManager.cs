using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cassantic.Core.Infrastructure
{
    public class ContainerManager
    {
        private readonly IContainer container;
        public ContainerManager(IContainer _container)
        {
            this.container = _container;
        }

        public IContainer Container { get { return container; } } 
    }
}
