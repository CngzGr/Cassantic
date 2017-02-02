using Autofac;
using Autofac.Integration.Mvc;
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
using System.Web;
using Cassantic.Service.Interceptors;
using Castle.DynamicProxy;
using Autofac.Extras.DynamicProxy;

namespace Cassantic.Builder
{
    public  class DependenciyRegistar : IDependencyRegistar
    {
        public  void Register(ContainerBuilder builder,ITypeFinder typeFinder) {

            var  types= typeFinder.GetAssembly().ToArray();
         
            builder.RegisterControllers(types);
            builder.Register<IDbContext>(c=> new CassanticContext()).AsSelf();
            builder.RegisterGeneric(typeof(CassanticRepository<>)).As(typeof(IRepository<>));

            #region Aspect

            builder.RegisterType<LogService>().Named<IInterceptor>("log-calls");

            #endregion

            #region Redis and Cassandra Register
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            MappingConfiguration.Global.Define<CassanticMapper>();
            builder.Register(c => cluster.Connect("cassantic")).As<ISession>();
            builder.Register(x => new CassandraCacheManager(x.Resolve<ISession>())).As<ICacheManager>().InstancePerDependency();
            builder.Register<IRedisClientsManager>(c => new PooledRedisClientManager("127.0.0.1:32768")).AsSelf();
            #endregion

            builder.RegisterType<RedisCacheManager>().As<ICacheManager>().Named<ICacheManager>("redis.cached").AsSelf();
            builder.RegisterType<CassandraCacheManager>().As<ICacheManager>().Named<ICacheManager>("cassandra.cached").AsSelf();
            builder.RegisterType<AccountService>().As<IAccountService>().EnableInterfaceInterceptors();
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
