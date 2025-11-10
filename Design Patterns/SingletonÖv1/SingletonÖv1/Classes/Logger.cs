using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonÖv1.Classes
{
    public sealed class Logger
    {
        private static Logger _logger;

        private List<string> _logs = new List<string>();

        private Logger() { }

        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }
            return _logger;
        }


        public void Log(string message)
        {
            _logs.Add(message);

            foreach (var item in _logs)
                Console.WriteLine(item);
        }
    }
}
