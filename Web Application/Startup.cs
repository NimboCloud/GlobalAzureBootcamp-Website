using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureBootCampV1.Startup))]
namespace AzureBootCampV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
