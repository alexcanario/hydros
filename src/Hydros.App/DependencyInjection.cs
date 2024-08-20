using FluentValidation;

using Microsoft.Extensions.DependencyInjection;

namespace Hydros.App;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;
        
        services.AddMediatR(config =>
            config.RegisterServicesFromAssembly(assembly));

        services.AddValidatorsFromAssembly(assembly);

        services.AddAutoMapper(AppDomain.CurrentDomain.Load("Hydros.App"));

        return services;
    }
}