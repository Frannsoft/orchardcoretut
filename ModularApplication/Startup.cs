using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ModularApplication.Features;
using NodaTime;
using OrchardCore.Environment.Shell;

namespace ModularApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOrchardCms();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOrchardCore();
            //app.UseOrchardCore(a => a.Run(async context =>
            //{
            //    shellsettings provide the tenant's config
            //    var shellSettings = context.RequestServices.GetRequiredService<ShellSettings>();

            //    read the tenant-specific custom setting
            //    var customSetting = shellSettings.Configuration["CustomSetting"];

            //    resolve all registered IMessageProvider services.
            //    var messageProviders = context.RequestServices.GetServices<IMessageProvider>();

            //    var messages = (await Task.WhenAll(messageProviders.Select(async x => await x.GetMessageAsync()))).ToList();

            //     add the custom setting as a message.  Alternatively, could have implemented another IMessageProvider that reads the settings
            //    messages.Insert(0, customSetting);

            //    var output = string.Join("\r\n", messages);

            //    await context.Response.WriteAsync(output);
            //}));
        }
    }
}
