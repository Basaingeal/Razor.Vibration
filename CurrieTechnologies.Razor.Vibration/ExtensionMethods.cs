using Microsoft.Extensions.DependencyInjection;

namespace CurrieTechnologies.Razor.Vibration
{
    public static class ExtensionMethods
    {
        public static IServiceCollection AddVibration(this IServiceCollection services)
        {
            return services.AddScoped<VibrationService>();
        }
    }
}
