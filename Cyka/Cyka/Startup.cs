using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cyka.Startup))]
namespace Cyka
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
