using System;
using Microsoft.Extensions.DependencyInjection;

namespace Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
       public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            //serviceCollection.AddDbContext<>();
            //serviceCollection.AddScoped<IUserOperationClaim,UserOperationClaimManager>();
            //write in startup.cs services.LoadMyServices();
            return serviceCollection;
        }
    }
}

