using DTI.SavioShop.Application.UseCase.Ports.Out;
using DTI.SavioShop.Application.UseCase.UseCase.Admin.Products.AddProduct;
using DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DTI.SavioShop.Tests.Integration.Admin.Products
{
    public class ProductTests
    {

        [Fact(DisplayName = "Product_Add_Success")]
        public async Task Product_Add_SuccessAsync()
        {
            var providers = GetProviders();
            var repository = providers.GetService<IProductRepository>();
            var addProductPortIn = new AddProductPortIn("nome", 10);
            var interector = new AddProductInterector(repository);
            var addProductPortOut = await interector.ExecuteAsync(addProductPortIn);
            var addedProduct = await repository.GetByIdAsync(addProductPortOut.Id);
            Assert.NotNull(addedProduct);

        }

        public IServiceProvider GetProviders()
        {
            var services = new ServiceCollection();
            services.AddAdapterDataAccess();
            var providers = services.BuildServiceProvider();
            return providers;
        }
    }
}
