using DTI.SavioShop.Application.DomainModel.Admin.Product;
using DTI.SavioShop.Application.UseCase.Ports.Out;

namespace DTI.SavioShop.Application.UseCase.UseCase.Admin.Products.AddProduct
{
    public class AddProductInterector
    {
        public readonly IProductRepository _repository;
        public AddProductInterector(IProductRepository repository )
        {
            _repository = repository;
        }

        public async Task<AddProductPortOut> ExecuteAsync(AddProductPortIn addProductPortIn)
        {
            var product = new Product(Guid.NewGuid(), addProductPortIn.Name, addProductPortIn.Value);
            await _repository.AddAsync(product);
            
            var portOut = new AddProductPortOut(product.Id);
            return portOut;
        }
    }
}
