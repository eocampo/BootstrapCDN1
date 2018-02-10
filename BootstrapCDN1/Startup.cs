using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BootstrapCDN1.Startup))]

namespace BootstrapCDN1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) {
            
        }
    }
}
