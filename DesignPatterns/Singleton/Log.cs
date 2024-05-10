using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "Log.txt";

        public static Log Instance
        {
            get { return _instance; }
        }
        private Log()
        {

        }

        public void Save(string mensaje)
        {
            File.AppendAllText(_path, mensaje + Environment.NewLine);
        }
    }
}
