using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webphutungxemay.Startup))]
namespace Webphutungxemay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
