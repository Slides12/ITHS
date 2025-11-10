using öv3.Interface;

namespace öv3.Classes
{
    public class OrderService
    {
        private INotifier notifier;

        public OrderService(INotifier notifier)
        {
            this.notifier = notifier;
        }

        public void ProcessOrder()
        {
            // logik...
            notifier.Send("Order processed!");
        }
    }
}


// kan aldrig lägga till mer än en notifier utan att ändra massa kod, det blir för tillfället endast en emailNotifier, inget annat. Med INotifier kan jag skicka in allt som implementerar det interfacet. Dunder