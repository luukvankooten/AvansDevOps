using Domain.Models.Discussions;
using Domain.Models.Notifications;

namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State patern
    /// </summary>
    public class BacklogContext
    {
        public BacklogContext(Item item, Notifier notifier = null)
        {
            State = new TodoState(this);
            Item = item;
            Notifier = notifier;
            ThreadDiscussion = new ThreadDiscussion(item);
        }

        public Item Item { get; set; }
        public Notifier Notifier { get; }
        public IBacklogState State { get; set; }
        public ThreadDiscussion ThreadDiscussion { get; }

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
