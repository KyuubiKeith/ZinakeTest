using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZinakeTest.Startup))]
namespace ZinakeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
