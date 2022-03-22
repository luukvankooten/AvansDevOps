using System;
using Domain.Models.BacklogPhases;

namespace Domain.Models.Notifications
{
    public interface IObserver
    {
        void Update(Item item);
    }
}
