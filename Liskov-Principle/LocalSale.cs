using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Principle
{
    public class LocalSale : SaleWithTaxes
    {
        public LocalSale(decimal amount, string customer, decimal taxes)
        {
            this.absAmount = amount;
            this.absCustomer = customer;
            this.absTaxes = taxes;
        }
        public override void Generate()
        {
            Console.WriteLine("Se generó la venta");
        }
        public override void CalculateTaxes()
        {
            Console.WriteLine("Se calculan los impuestos");
        }
    }
}
