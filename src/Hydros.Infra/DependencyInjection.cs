using Microsoft.Extensions.DependencyInjection;

namespace Hydros.Infra.Data;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}