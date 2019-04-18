using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFunLearn.Startup))]
namespace MVCFunLearn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
