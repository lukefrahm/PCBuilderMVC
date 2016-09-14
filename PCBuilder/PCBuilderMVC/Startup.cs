using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCBuilderMVC.Startup))]
namespace PCBuilderMVC
{
    /// <summary>
    /// Startup configuration class.
    /// </summary>
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
