using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed
{
    public interface IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public decimal CalculateSalaryMonthly();
    }
}
