using System.Collections.Generic;

namespace Domain.Models.Notifications
{
    /// <summary>
    /// Observer pattern
    /// </summary>
    public class Notifier
    {
        private List<IObserver> observers = new List<IObserver>();

        public Notifier(Sprint sprint)
        {
            Sprint = sprint;
        }

        public Sprint Sprint { get; }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(Sprint);
            }
        }

    }
}
