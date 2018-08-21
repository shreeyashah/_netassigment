using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identity_user.Startup))]
namespace Identity_user
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
