using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTI.SavioShop.Application.UseCase.UseCase.Admin.Products.AddProduct
{
    public class AddProductPortOut
    {
        public AddProductPortOut(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
