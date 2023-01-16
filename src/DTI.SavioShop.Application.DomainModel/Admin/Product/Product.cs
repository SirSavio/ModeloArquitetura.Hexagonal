namespace DTI.SavioShop.Application.DomainModel.Admin.Product
{
    public class Product
    {
        public Product(Guid id, string name, double value)
        {
            Id = id;
            Name = name;
            Value = value;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public double Value { get; private set; }
    }
}
