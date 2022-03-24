using System;
using System.Collections.Generic;
using Domain.Models.Notifications;

namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State patern
    /// </summary>
    public class BacklogContext
    {
        public BacklogContext(Item item, Notifier notifier)
        {
            State = new TodoState(this);
            Item = item;
            Notifier = notifier;
        }

        public Item Item { get; set; }
        public Notifier Notifier { get; }
        public IBacklogState State { get; set; }

        public void Doing()
        {
            State = State.Doing();
        }

        public void Done()
        {
            State = State.Done();
        }

        public void ReadyForTesting()
        {
            State = State.ReadyForTesting();
        }

        public void Tested()
        {
            State = State.Tested();
        }

        public void Testing()
        {
            State = State.Testing();
        }

        public void Todo()
        {
            State = State.Todo();
        }

    }
}
