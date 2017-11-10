using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfoDeck.Startup))]
namespace InfoDeck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
