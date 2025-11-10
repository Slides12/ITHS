using öv4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öv4.Classes
{
    public class SwishPayment : IPaymentProcessor
    {
        public void Update(string message)
        {
            Console.WriteLine($"Swish:{message}");
        }
    }
}
