﻿using DotNET9EntityFramework.Abstraction;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DotNET9EntityFramework.Extensions
{
    public static class MapEndpointExtensions
    {
        public static IServiceCollection RegisterEndpointsFromAssemblyContaining<T>(this IServiceCollection services)
        {
            var assembly = typeof(T).Assembly;

            var endpointTypes = assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(IEndpoint)) && t is { IsClass: true, IsAbstract: false, IsInterface: false });

            var serviceDescriptors = endpointTypes
                .Select(type => ServiceDescriptor.Transient(typeof(IEndpoint), type))
                .ToArray();

            services.TryAddEnumerable(serviceDescriptors);
            return services;
        }

        public static WebApplication MapEndpoints(this WebApplication app)
        {
            var endpoints = app.Services.GetRequiredService<IEnumerable<IEndpoint>>();

            foreach (var endpoint in endpoints)
            {
                endpoint.MapEndpoint(app);
            }

            return app;
        }
    }
}
