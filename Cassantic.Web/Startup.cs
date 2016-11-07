using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cassantic.Web.Startup))]
namespace Cassantic.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
             ConfigureAuth(app);
        }
    }
}
