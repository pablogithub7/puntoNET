using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenNET.Startup))]
namespace ExamenNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
