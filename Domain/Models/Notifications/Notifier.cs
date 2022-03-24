using System;
using System.Collections.Generic;
using Domain.Models.BacklogPhases;

namespace Domain.Models.Notifications
{
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
