using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.Jutland.Newtonsoft;


namespace R5T.Jutland.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IJsonFileSerializationOperator"/> service.
        /// </summary>
        public static IServiceCollection AddJsonFileSerializationOperator(this IServiceCollection services)
        {
            services.AddNewtonsoftJsonFileSerializationOperator();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IJsonFileSerializationOperator"/> service.
        /// </summary>
        public static ServiceAction<IJsonFileSerializationOperator> AddJsonFileSerializationOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IJsonFileSerializationOperator>(() => services.AddJsonFileSerializationOperator());
            return serviceAction;
        }
    }
}
