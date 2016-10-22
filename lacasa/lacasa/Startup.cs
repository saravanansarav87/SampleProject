using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lacasa.Startup))]
namespace lacasa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
