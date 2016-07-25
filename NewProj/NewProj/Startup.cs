using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewProj.Startup))]
namespace NewProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
