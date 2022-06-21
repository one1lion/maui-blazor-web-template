using MauiBlazorWebTemplate.Shared.Extensions;
using MauiBlazorWebTemplate.Shared.ServiceInterfaces;
using MauiBlazorWebTemplate.Wasm;
using MauiBlazorWebTemplate.Wasm.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register and add services for shared using the extension method
// located in *.Shared/Extensions/ServiceExtensions.cs
builder.Services.AddSharedServices();

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

await builder.Build().RunAsync();
