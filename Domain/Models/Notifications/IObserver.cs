using System;
using Domain.Models.BacklogPhases;

namespace Domain.Models.Notifications
{
    /// <summary>
    /// Observer pattern
    /// </summary>
    public interface IObserver
    {
        void Update(Sprint sprint);
    }
}
