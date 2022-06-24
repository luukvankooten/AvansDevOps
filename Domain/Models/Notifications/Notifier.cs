using System.Collections.Generic;

namespace Domain.Models.Notifications
{
    /// <summary>
    /// Observer pattern
    /// </summary>
    public abstract class Notifier
    {
        private List<ISprintObserver> observers = new();

        public void AddObserver(ISprintObserver observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(ISprintObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in observers)
            {
                Update(o);
            }
        }

        protected abstract void Update(ISprintObserver observer);

    }
}
