using DTI.SavioShop.Application.DomainModel.Admin.Product;
using System;
using Xunit;

namespace DTI.SavioShop.Tests.Unit.Admin.Products
{
    public class ProductTests
    {

        [Fact(DisplayName = "Product_New_Success")]
        public void Product_New_Success()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var name = "nome_teste";
            var value = 10;
            
            // Act
            var product = new Product(productId, name, value);
            
            // Assert
            Assert.Equal(productId, product.Id);
            Assert.Equal(name, product.Name);
            Assert.Equal(value, product.Value);
        }
    }
}
