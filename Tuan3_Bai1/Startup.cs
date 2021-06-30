using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan3_Bai1.Startup))]
namespace Tuan3_Bai1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
