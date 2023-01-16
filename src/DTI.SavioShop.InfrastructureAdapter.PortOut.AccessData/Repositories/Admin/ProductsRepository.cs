using DTI.SavioShop.Application.DomainModel.Admin.Product;
using DTI.SavioShop.Application.UseCase.Ports.Out;
using DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData.Context;
using Microsoft.EntityFrameworkCore;

namespace DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData.Repositories.Admin
{
    internal class ProductsRepository : IProductRepository
    {
        private readonly SavioShopDb _context;

        public ProductsRepository(SavioShopDb context)
        {
            _context = context;
        }
        public async Task AddAsync(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var product = await _context.Products.FirstAsync(product => product.Id == id);
            return product;
        }
    }
}
