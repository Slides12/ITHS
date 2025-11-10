


using öv2.Classes;

var factory = new Factory();

factory.Register("email", new EmailNotifier());
factory.Register("sms", new SMSNotifier());

var email = factory.GetInstance("email");
var sms = factory.GetInstance("sms");

email?.Send("Hallå eller!");
sms?.Send("Hallå eller!");