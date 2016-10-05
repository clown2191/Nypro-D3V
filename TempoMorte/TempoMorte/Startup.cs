using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TempoMorte.Startup))]
namespace TempoMorte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
