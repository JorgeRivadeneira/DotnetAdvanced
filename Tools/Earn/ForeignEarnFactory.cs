using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class ForeignEarnFactory : EarnFactory
    {
        private decimal _percentaje;
        private decimal _extra;

        public ForeignEarnFactory(decimal percentaje, decimal extra)
        {
            _extra = extra;
            _percentaje = percentaje;
        }
        public override IEarn GetEarn()
        {
            return new ForeignEarn(_percentaje, _extra);
        }
    }
}
