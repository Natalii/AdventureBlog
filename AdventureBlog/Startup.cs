using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdventureBlog.Startup))]
namespace AdventureBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
