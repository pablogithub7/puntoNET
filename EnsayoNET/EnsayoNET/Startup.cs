using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnsayoNET.Startup))]
namespace EnsayoNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
