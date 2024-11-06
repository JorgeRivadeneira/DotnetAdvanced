using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Principle
{
    public abstract class AbstractSale //T
    {
        protected decimal absAmount;
        protected string absCustomer;
        //protected decimal absTaxes;

        public abstract void Generate();
        //public abstract void CalculateTaxes();
    }
}
