using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomCables.Startup))]
namespace CustomCables
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
