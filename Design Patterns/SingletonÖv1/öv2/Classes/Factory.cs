using öv2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öv2.Classes
{
    public class Factory
    {

        private readonly Dictionary<string, INotifier> _notifiers = new();

        public void Register(string key, INotifier notifier)
        {
            _notifiers[key] = notifier;
        }

        public INotifier? GetInstance(string key)
        {
            if (_notifiers.ContainsKey(key))
                return _notifiers[key];

            return null;
        }

    }
}
