using öv5.Interface;

namespace öv5.Classes
{
    public class SlackNotifier: NotifierDecorator
    {
        public SlackNotifier(INotifier inner) : base(inner) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SLACK: {message}");
        }
    }
}
