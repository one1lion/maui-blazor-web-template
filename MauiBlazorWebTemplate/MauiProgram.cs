using MauiBlazorWebTemplate.Services;
using MauiBlazorWebTemplate.Shared.Extensions;
using MauiBlazorWebTemplate.Shared.ServiceInterfaces;

namespace MauiBlazorWebTemplate;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        // Register and add services for shared using the extension method
        // located in *.Shared/Extensions/ServiceExtensions.cs
        builder.Services.AddSharedServices();

        builder.Services.AddSingleton<IWeatherForecastService, WeatherForecastService>();

        return builder.Build();
    }
}
