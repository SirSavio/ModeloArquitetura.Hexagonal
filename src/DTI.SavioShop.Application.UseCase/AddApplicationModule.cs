using DTI.SavioShop.Application.UseCase.Ports.Out;
using Microsoft.Extensions.DependencyInjection;

namespace DTI.SavioShop.Application.UseCase
{
    public static class AddApplicationModule
    {
        public static IServiceCollection AddApplication<TProductRepository>(this IServiceCollection service)
            where TProductRepository : class, IProductRepository
        {
            service.AddScoped<IProductRepository, TProductRepository>();
            return service;
        }
    }
}
