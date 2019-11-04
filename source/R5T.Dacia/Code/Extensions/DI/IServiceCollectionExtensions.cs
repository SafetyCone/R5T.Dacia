using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;


namespace R5T.Dacia.Extensions
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Get a service out of the current state of the service collection.
        /// </summary>
        /// <remarks>
        /// Build a service provider from the current state of the service collection and get a required service.
        /// </remarks>
        public static T GetIntermediateRequiredService<T>(this IServiceCollection services)
        {
            var intermediateServiceProvider = services.BuildServiceProvider();

            var output = intermediateServiceProvider.GetRequiredService<T>();
            return output;
        }

        public static IServiceCollection TryAddSingletonFluent<TService, TImplementation>(this IServiceCollection services)
            where TImplementation: class, TService
            where TService: class
        {
            services.TryAddSingleton<TService, TImplementation>();

            return services;
        }
    }
}
