using öv4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öv4.Classes
{
    public class Factory
    {
        private readonly Dictionary<string, IPaymentProcessor> _processors = new();

        public void Register(string key, IPaymentProcessor processor)
        {
            _processors[key] = processor;
        }

        public IPaymentProcessor? GetInstance(string key)
        {
            if (_processors.ContainsKey(key))
                return _processors[key];

            return null;
        }
    }
}
