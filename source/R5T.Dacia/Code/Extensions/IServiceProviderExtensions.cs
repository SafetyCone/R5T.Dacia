using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.Dacia.Extensions
{
    public static class IServiceProviderExtensions
    {
        public static bool TryGetService<TService>(this IServiceProvider serviceProvider, out TService service)
            where TService: class
        {
            service = serviceProvider.GetService<TService>();

            var output = ServiceHelper.IsNullService(service);
            return output;
        }

        public static bool HasService<TService>(this IServiceProvider serviceProvider)
            where TService: class
        {
            var output = serviceProvider.TryGetService<TService>(out _);
            return output;
        }
    }
}
