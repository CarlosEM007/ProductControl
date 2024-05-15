using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductControl.Entities
{
    public class UsedProducts : Product
    {
        public DateTime ManufactureDate;

        public UsedProducts(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
