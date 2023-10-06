using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InvoiceManagerMVC.Startup))]
namespace InvoiceManagerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
