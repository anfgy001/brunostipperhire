using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrunosTipperHire.Startup))]
namespace BrunosTipperHire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
