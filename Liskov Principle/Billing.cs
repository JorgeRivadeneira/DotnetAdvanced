using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Principle
{
    public class Billing
    {
        public void RealizarCobro(ILicencia licencia)
        {
            var tarifa = licencia.CalcularTarifa();
        }
    }
}
