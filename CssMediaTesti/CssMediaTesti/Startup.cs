using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CssMediaTesti.Startup))]
namespace CssMediaTesti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
