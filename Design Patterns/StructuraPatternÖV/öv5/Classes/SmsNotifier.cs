using öv5.Interface;

namespace öv5.Classes
{
    public class SmsNotifier : NotifierDecorator
    {
        public SmsNotifier(INotifier inner) : base(inner) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SMS: {message}");
        }
    }
}
