using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class BikeStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una bicileta y me muevo a pie");
        }
    }
}
