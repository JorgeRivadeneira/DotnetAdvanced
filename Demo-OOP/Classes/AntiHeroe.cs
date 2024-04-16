using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP.Classes
{
    public class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiHeroe(string accion)
        {
            return $"El  antiheroe {NombreEIdentidadSecreta} ha realizado: {accion}";
        }
    }
}
