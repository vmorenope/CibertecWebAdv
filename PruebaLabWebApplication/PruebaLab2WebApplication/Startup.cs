using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaLab2WebApplication.Startup))]
namespace PruebaLab2WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
