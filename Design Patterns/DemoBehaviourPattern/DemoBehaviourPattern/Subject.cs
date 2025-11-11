using DemoBehaviourPattern.Interface;

namespace DemoBehaviourPattern
{
    public class Subject : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();
        private string _productNameMyProperty { get; set; }
        private string available { get; set; }

        public Subject(string productNameMyProperty, string available)
        {
            _productNameMyProperty = productNameMyProperty;
            this.available = available;
        }

        public void NotifyObservers()
        {
            foreach(var observer in _observers)
            {
                observer.Notify(available);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void SetAvailability(string available)
        {
           this.available = available;
        }
    }
}
