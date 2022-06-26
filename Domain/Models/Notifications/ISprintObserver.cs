using System;
using Domain.Models.BacklogPhases;

namespace Domain.Models.Notifications
{
    /// <summary>
    /// Observer pattern
    /// </summary>
    public interface ISprintObserver
    {
        void Update(Sprint sprint, Member[] members, string message);

        void Update(Item item, Member[] members, string message);
    }
}
