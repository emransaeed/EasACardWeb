using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasACardWeb.Startup))]
namespace EasACardWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
