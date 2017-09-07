using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobSearch.Web.Startup))]
namespace JobSearch.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
