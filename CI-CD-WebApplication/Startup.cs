using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CI_CD_WebApplication.Startup))]
namespace CI_CD_WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
