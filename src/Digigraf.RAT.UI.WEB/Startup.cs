using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Digigraf.RAT.UI.WEB.Startup))]
namespace Digigraf.RAT.UI.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
