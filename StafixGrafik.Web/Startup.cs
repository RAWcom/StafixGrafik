using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StafixGrafik.Web.Startup))]
namespace StafixGrafik.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
