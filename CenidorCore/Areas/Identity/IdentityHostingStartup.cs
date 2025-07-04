using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CenidorCore.Areas.Identity.IdentityHostingStartup))]
namespace CenidorCore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}