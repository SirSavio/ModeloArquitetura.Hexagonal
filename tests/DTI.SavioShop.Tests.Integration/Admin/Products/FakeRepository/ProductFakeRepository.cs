using DTI.SavioShop.Application.DomainModel.Admin.Product;
using DTI.SavioShop.Application.UseCase.Ports.Out;
using System;
using System.Threading.Tasks;

namespace DTI.SavioShop.Tests.Integration.Admin.Products.FakeRepository
{
    internal class ProductFakeRepository : IProductRepository
    {
        public async Task AddAsync(Product product)
        {
            
        }

        public Task<Product> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
