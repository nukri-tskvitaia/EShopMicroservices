namespace Ordering.API;

public static class DependencyInjection
{
    // Before building the application
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        return services;
    }

    // After building the application
    public static WebApplication UseApiServices(this WebApplication app)
    {
        return app;
    }
}
