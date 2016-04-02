using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningCurve.Startup))]
namespace LearningCurve
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
