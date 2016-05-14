using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trials.Startup))]
namespace Trials
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
