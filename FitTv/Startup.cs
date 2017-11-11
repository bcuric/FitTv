using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitTv.Startup))]
namespace FitTv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
