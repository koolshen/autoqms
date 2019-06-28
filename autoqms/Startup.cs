using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(autoqms.Startup))]
namespace autoqms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
