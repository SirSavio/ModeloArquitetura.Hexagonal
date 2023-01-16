namespace DTI.SavioShop.Application.UseCase.UseCase.Admin.Products.AddProduct
{
    public class AddProductPortIn
    {
        public AddProductPortIn()
        {

        }
        public AddProductPortIn(string name, double value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; set; }

        public double Value { get; set; }
    }
}
