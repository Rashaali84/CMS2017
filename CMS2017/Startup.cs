using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMS2017.Startup))]
namespace CMS2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
