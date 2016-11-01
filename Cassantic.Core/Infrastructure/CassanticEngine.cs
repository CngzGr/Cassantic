using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Integration.Mvc;
using System.Web.Mvc;

namespace Cassantic.Core.Infrastructure
{
    public class CassanticEngine:IEngine
    {
        public void Initialize() {

            var typeFinder = new WebTypeFinder();

            var builder = new ContainerBuilder();
            var container = builder.Build();
            builder = new ContainerBuilder();
            this._containerManager = new ContainerManager(container);
            var dependencyRegistar = typeFinder.FindClassesOfType(typeof(IDependencyRegistar));
            var dependencyInstances=new List<IDependencyRegistar>();
            foreach (var item in dependencyRegistar)
            {
                dependencyInstances.Add((IDependencyRegistar)Activator.CreateInstance(item));
            }
            foreach (var item in dependencyInstances)
            {
                item.Register(builder, typeFinder);
            }
  
            builder.Update(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

       

        
        }

        private ContainerManager _containerManager;
     
        public ContainerManager ContainerManaer
        {
            get { return _containerManager; }
        }


        public T Resolve<T>() where T : class
        {
            return ContainerManaer.Container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return ContainerManaer.Container.Resolve(type);
        }

        public T[] ResolveAll<T>()
        {
           return ContainerManaer.Container.Resolve<IEnumerable<T>>().ToArray();
        }
    }
}
