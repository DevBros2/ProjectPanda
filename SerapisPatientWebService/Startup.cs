using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SerapisPatientWebService.Startup))]

namespace SerapisPatientWebService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}