using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlphaASPWebsite.Startup))]
namespace AlphaASPWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
