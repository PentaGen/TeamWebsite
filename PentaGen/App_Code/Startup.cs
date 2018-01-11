using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PentaGen.Startup))]
namespace PentaGen
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
