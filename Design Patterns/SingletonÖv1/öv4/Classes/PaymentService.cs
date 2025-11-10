using öv4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öv4.Classes
{
    public class PaymentService
    {
        private IPaymentProcessor _paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void DoSomething(string message)
        {
            _paymentProcessor.Update(message);
        }
    }
}
