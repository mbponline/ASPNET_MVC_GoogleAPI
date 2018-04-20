using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleExternalLogin.Startup))]
namespace GoogleExternalLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
