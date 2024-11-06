using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Principle
{
    public class ForeignSale : AbstractSale
    {
        public ForeignSale(decimal amount, string customer)
        {
            this.absAmount = amount;
            this.absCustomer = customer;
        }

        public override void Generate()
        {
            Console.WriteLine("Generando la factura");
        }
    }
}
