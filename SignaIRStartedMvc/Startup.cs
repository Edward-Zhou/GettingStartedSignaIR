using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignaIRStartedMvc.Startup))]
namespace SignaIRStartedMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);

        }
    }
}
