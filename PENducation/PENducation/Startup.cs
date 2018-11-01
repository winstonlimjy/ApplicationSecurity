using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PENducation.Startup))]
namespace PENducation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
