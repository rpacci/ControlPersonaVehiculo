using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticaCaliifada.Startup))]
namespace PracticaCaliifada
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
