using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Cassantic.Builder;
using Autofac.Integration.Mvc;
using Autofac;
using Autofac.Core;
using Autofac.Integration.WebApi;
using System.Reflection;
using Cassantic.Controllers;
using Cassantic.Core.Caching;
using Cassantic.Core.Infrastructure;

namespace Cassantic
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {


            EngineManager.Initialize();
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var webApiResolver = new AutofacWebApiDependencyResolver( EngineManager.Current.ContainerManaer.Container);
            GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;

            
        }
    }
}