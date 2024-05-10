using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class ForeignEarn : IEarn
    {
        private decimal _percentaje;
        private decimal _extra;

        public ForeignEarn(decimal percentaje, decimal extra)
        {
            _extra = extra;
            _percentaje = percentaje;
        }

        public decimal Earn(decimal amount)
        {
            return (amount * _percentaje) + _extra;
        }
    }
}
