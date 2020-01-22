using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoonMIS4200.Startup))]
namespace HoonMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
