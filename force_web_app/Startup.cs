using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(force_web_app.Startup))]
namespace force_web_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
