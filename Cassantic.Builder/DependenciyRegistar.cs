using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Cassandra;
using Cassantic.Core.Caching;
using Cassantic.Data;
using Cassantic.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Cassandra.Mapping;
using Cassantic.Core.Caching.CassandraMapper;
using StackExchange.Redis;
using ServiceStack.Redis;
using Cassantic.Core.Infrastructure;
using Cassantic.Service.Common;

namespace Cassantic.Builder
{
    public  class DependenciyRegistar : IDependencyRegistar
    {
        public  void Register(ContainerBuilder builder,ITypeFinder typeFinder) {

            var  types= typeFinder.GetAssembly().ToArray();
            builder.RegisterControllers(types);
            builder.RegisterApiControllers(types);

            builder.Register<IDbContext>(c=> new CassanticContext()).InstancePerHttpRequest();
            builder.RegisterGeneric(typeof(CassanticRepository<>)).As(typeof(IRepository<>)).InstancePerHttpRequest();

            #region Redis and Cassandra Register
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            MappingConfiguration.Global.Define<CassanticMapper>();
            builder.Register(c => cluster.Connect("cassantic")).As<ISession>();
            builder.Register(x => new CassandraCacheManager(x.Resolve<ISession>())).As<ICacheManager>().InstancePerDependency();
            builder.Register<IRedisClientsManager>(c => new PooledRedisClientManager("127.0.0.1:32768")).InstancePerLifetimeScope();
            #endregion

            builder.RegisterType<RedisCacheManager>().As<ICacheManager>().Named<ICacheManager>("redis.cached").InstancePerHttpRequest();
            builder.RegisterType<CassandraCacheManager>().As<ICacheManager>().Named<ICacheManager>("cassandra.cached").InstancePerHttpRequest();
          
            var consumers = typeFinder.FindClassesOfType(typeof(IConsumer<>)).ToList();
            foreach (var item in consumers)
            {
                builder.RegisterType(item).As(item.FindInterfaces((type, criteria) =>
                {
                    var isMatch = type.IsGenericType && ((Type)criteria).IsAssignableFrom(type.GetGenericTypeDefinition());
                    return isMatch;

                }, typeof(IConsumer<>)));

            }
            
        }

    }
}
