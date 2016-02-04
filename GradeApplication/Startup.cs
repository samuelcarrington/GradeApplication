using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GradeApplication.Startup))]
namespace GradeApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
