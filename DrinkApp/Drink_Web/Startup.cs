using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Drink_Web.Startup))]
namespace Drink_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
