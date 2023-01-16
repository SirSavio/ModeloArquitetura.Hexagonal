using DTI.SavioShop.Application.DomainModel.Admin.Product;
using DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData.FluantApi.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData.FluantApi.Admin.Produts
{
    public class ProductFA : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Name).HasMaxLength(DataAccessConstants.MAX_LENGTH);
        }
    }
}
