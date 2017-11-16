using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IBTA.ListaRamais.Startup))]
namespace IBTA.ListaRamais
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
