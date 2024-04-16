using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP.Classes
{
    public class SuperPoder
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public NivelPoder Nivel { get; set; }

        public SuperPoder()
        {
            Nivel = NivelPoder.Debil;
        }
    }

    public enum NivelPoder
    {
        Debil,
        MasOMenos,
        Fuerte,
        SuperFuerte
    }
}
