using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetRental.WebMVC1.Startup))]
namespace PetRental.WebMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
