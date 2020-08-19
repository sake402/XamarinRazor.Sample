using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using XaaRinRazor.Sample.Services;

namespace XamarinRazor.Sample.Startup
{
    public static class ServiceRegistrar
    {
        public static void RegisterAppServices(this IServiceCollection services)
        {
            services.AddScoped<AuthenticationProvider>()
            .AddScoped<AuthenticationStateProvider>(sp => sp.GetRequiredService<AuthenticationProvider>())
            .AddScoped<IAuthorizationService>(sp => sp.GetRequiredService<AuthenticationProvider>())
            .AddScoped<IAuthorizationPolicyProvider>(sp => sp.GetRequiredService<AuthenticationProvider>());
        }
    }
}
