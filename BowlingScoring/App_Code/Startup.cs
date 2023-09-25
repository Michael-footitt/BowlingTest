using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BowlingScoring.Startup))]
namespace BowlingScoring
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
