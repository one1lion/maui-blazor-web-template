using Microsoft.Extensions.DependencyInjection;

namespace MauiBlazorWebTemplate.Shared.Extensions;

public static class ServiceExtensions
{
    /// <summary>
    /// Register the services shared across all UI applications that use
    /// this library
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection" /></param>
    /// <remarks>
    /// In each of the Program.cs classes for the projects, use:
    /// <code>builder.Services.AddSharedServices();</code>
    /// </remarks>
    public static void AddSharedServices(this IServiceCollection services)
    {

    }
}
