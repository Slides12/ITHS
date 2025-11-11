using öv5.Interface;

namespace öv5.Classes
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"EMAIL: {message}");
        }
    }
}
