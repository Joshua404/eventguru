using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEventsProject.Startup))]
namespace MyEventsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
