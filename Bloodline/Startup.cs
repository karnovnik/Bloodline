using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bloodline.Startup))]
namespace Bloodline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
