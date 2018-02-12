using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleMultitenancy.Startup))]
namespace ExampleMultitenancy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
