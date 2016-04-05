using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Cars.Startup))]
namespace MVC_Cars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
