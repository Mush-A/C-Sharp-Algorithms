using Microsoft.Extensions.DependencyInjection;

namespace Interview;

public static class ConfigureServices
{
    public static IServiceCollection AddProccessor(this IServiceCollection services)
    {
        services.AddSingleton<IProcessorServiceFactory, ProcessorServiceFactory>();
        return services;
    }
}
