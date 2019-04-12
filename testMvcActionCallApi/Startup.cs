using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testMvcActionCallApi.Startup))]
namespace testMvcActionCallApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
