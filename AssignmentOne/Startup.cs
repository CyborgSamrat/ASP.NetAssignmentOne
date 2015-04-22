using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentOne.Startup))]
namespace AssignmentOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
