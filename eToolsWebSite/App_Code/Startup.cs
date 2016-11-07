using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eToolsWebSite.Startup))]
namespace eToolsWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
