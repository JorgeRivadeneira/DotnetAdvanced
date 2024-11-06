using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Principle
{
    public abstract class SaleWithTaxes : AbstractSale
    {
        protected decimal absTaxes;
        public abstract void CalculateTaxes();
    }
}
