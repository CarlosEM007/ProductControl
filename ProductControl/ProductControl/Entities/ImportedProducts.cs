using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductControl.Entities
{
    public class ImportedProducts : Product
    {
        public double CustomFee;

        public ImportedProducts(string name, double price, double customFee) : base(name, price)
        {
            Name = name;
            Price = price;
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {Price + CustomFee} (Custom Fee: $ {CustomFee})";
        }
    }
}
