using System;
using Domain.Models.BacklogPhases;

namespace Domain.Models.Notifications
{
    /// <summary>
    /// Observer pattern
    /// </summary>
    public interface ISprintObserver
    {
        void Update(Sprint sprint);

        void Update(Item item);
    }
}
