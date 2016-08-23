using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogExersice.Startup))]
namespace BlogExersice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
