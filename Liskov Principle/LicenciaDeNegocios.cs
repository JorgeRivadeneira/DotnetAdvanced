using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Principle
{
    public class LicenciaDeNegocios : ILicencia
    {
        public decimal CalcularTarifa()
        {
            throw new NotImplementedException();
        }
    }
}
