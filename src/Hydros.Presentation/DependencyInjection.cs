﻿using Microsoft.Extensions.DependencyInjection;

namespace Hydros.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}