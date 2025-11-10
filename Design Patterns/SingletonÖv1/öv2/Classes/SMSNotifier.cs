using öv2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öv2.Classes
{
    public class SMSNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"EMAIL:{message}");
        }
    }
}
