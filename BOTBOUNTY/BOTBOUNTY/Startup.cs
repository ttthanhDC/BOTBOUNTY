using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BOTBOUNTY.Startup))]
namespace BOTBOUNTY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
