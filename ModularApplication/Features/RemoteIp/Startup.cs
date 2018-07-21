using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly: OrchardCore.Modules.Manifest.Feature(
    Id = "RemoteIp",
    Name = "RemoteIp"
)]

namespace ModularApplication.Features.RemoteIp
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMessageProvider, RemoteIpMessageProvider>();
        }
    }
}
