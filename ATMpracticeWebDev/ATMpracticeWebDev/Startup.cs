using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATMpracticeWebDev.Startup))]
namespace ATMpracticeWebDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
