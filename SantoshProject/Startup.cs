using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SantoshProject.Startup))]
namespace SantoshProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
