using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VECTOR.Startup))]
namespace VECTOR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
