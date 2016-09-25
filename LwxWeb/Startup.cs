using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LwxWeb.Startup))]
namespace LwxWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
