using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Baitap1_Server.Startup))]

namespace Baitap1_Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}