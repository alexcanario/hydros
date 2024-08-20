using Microsoft.Extensions.DependencyInjection;

namespace Hydros.Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}