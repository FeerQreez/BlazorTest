using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace TestWasm
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTelerikBlazor();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
