using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class Main
    {
        public Main()
        {
            var context = new Context(new CarStrategy());
            context.Run();
            context.Strategy = new MotoStrategy();
            context.Run();
            context.Strategy = new BikeStrategy();
            context.Run();
        }
    }
}
