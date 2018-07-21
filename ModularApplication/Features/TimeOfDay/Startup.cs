using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

[assembly: OrchardCore.Modules.Manifest.Feature(
    Id = "TimeOfDay",
    Name = "TimeOfDay"
)]


namespace ModularApplication.Features.TimeOfDay
{

    [Feature("TimeOfDay")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMessageProvider, TimeOfDayMessageProvider>();
        }
    }
}
