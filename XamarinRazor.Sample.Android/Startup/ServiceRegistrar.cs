using Microsoft.Extensions.DependencyInjection;
using XamarinRazor.Sample.Startup;

namespace RAGPWealthGate.Droid.Startup
{
    public static class ServiceRegistrar
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.RegisterAppServices();
        }
    }
}