using System;

using Microsoft.Extensions.DependencyInjection;


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
    }
}
