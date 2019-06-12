using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleLoggerWeb.Startup))]
namespace SimpleLoggerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
