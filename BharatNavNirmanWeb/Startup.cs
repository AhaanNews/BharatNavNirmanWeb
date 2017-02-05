using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BharatNavNirmanWeb.Startup))]
namespace BharatNavNirmanWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
