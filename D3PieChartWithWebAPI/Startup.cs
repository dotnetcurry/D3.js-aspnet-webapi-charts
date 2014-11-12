using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(D3PieChartWithWebAPI.Startup))]
namespace D3PieChartWithWebAPI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
