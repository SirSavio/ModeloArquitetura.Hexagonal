using DTI.SavioShop.Application.UseCase;
using DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData.Context;
using DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData.Repositories.Admin;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData
{
    public static class AddAdapterDataAccessModule
    {
        public static IServiceCollection AddAdapterDataAccess(this IServiceCollection services)
        {
            services.AddDbContext<SavioShopDb>();
            services.AddApplication<ProductsRepository>();
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = "localhost:6379";
            });
            return services;
        }
    }
}
