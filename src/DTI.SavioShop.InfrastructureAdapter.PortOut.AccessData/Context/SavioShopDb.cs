using DTI.SavioShop.Application.DomainModel.Admin.Product;
using DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData.FluantApi.Admin.Produts;
using Microsoft.EntityFrameworkCore;

namespace DTI.SavioShop.InfrastructureAdapter.PortOut.AccessData.Context
{
    internal class SavioShopDb : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductFA());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=NextWaveEducation; User Id=SA; password=yourStrong(!)Password");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
