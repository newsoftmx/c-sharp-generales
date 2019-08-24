using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenJavierAjax.Startup))]
namespace ExamenJavierAjax
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
