using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGithub.Startup))]
namespace TestGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
