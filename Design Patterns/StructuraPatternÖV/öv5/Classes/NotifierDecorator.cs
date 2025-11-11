using öv5.Interface;

namespace öv5.Classes
{
    public abstract class NotifierDecorator : INotifier
    {
        private readonly INotifier _notifier;

        protected NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}
