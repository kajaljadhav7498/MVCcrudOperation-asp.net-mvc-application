using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCcrudOperation.Startup))]
namespace MVCcrudOperation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
