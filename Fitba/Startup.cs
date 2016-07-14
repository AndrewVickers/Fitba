using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fitba.Startup))]
namespace Fitba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
