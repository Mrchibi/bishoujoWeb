using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bishoujoWeb.Startup))]
namespace bishoujoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
