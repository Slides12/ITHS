using DemoBehaviourPattern.Interface;

namespace DemoBehaviourPattern
{
    public class Observer : IObserver
    {
        public string Email { get; set; }

        public Observer(string email, ISubject subject)
        {
            Email = email;
            subject.RegisterObserver(this);
        }

        public void Notify(string available)
        {
            Console.WriteLine($"Nu är produkten {available}");
        }
    }
}
