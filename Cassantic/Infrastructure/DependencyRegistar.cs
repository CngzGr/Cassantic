using Cassantic.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using Cassantic.Controllers;
using Autofac.Core;
using Cassantic.Core.Caching;

namespace Cassantic.Infrastructure
{
    public class DependencyRegistar:IDependencyRegistar
    {
        public void Register(Autofac.ContainerBuilder builder, ITypeFinder typeFinder)
        {
           
            builder.RegisterType<HomeController>().WithParameter(ResolvedParameter.ForNamed<ICacheManager>("redis.cached"));
        }
    }
}