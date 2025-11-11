namespace DemoBehaviourPattern.Interface
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
        void SetAvailability(string available);
    }
}
