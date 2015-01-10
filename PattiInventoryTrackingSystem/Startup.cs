using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PattiInventoryTrackingSystem.Startup))]
namespace PattiInventoryTrackingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
