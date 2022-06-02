using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(bri4iparts.Areas.Identity.IdentityHostingStartup))]
namespace bri4iparts.Areas.Identity
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