

using öv4.Classes;
using System.Diagnostics;

var factory = new Factory();

factory.Register("paypal", new PayPalPayment());
factory.Register("swish", new SwishPayment());
factory.Register("creditCard", new CreditCardPayment());

var payService = new PaymentService(factory.GetInstance("paypal"));

payService.DoSomething("yo mama");