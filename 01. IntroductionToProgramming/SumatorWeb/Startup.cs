using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumatorWeb.Startup))]
namespace SumatorWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
