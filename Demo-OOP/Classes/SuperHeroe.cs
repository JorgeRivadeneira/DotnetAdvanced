using Demo_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP.Classes
{
    public class SuperHeroe: Heroe, ISuperHeroe
    {
        public int Id { get; set; }

        public string IdentidadSecreta { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public List<SuperPoder> SuperPoderes { get; set; }
        public bool PuedeVolar { get; set; }

        //Encapsulamiento
        private string _Name;

        public override string Name 
        {
            get { return _Name; }
            set
            {
                _Name = value.Trim();
            } 
        }

        public string NombreEIdentidadSecreta
        {
            get { return $"{Name} ({IdentidadSecreta})";  }
        }

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in  SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} está usando el super poder: {item.Nombre}");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            return string.Empty;
        }

    }
}
