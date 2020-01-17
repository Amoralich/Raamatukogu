using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Raamatukogu.Startup))]
namespace Raamatukogu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
