using System;
namespace Domain.Models.BacklogPhases
{
    public class BacklogContext
    {
        public BacklogContext(Item item)
        {
            State = new Todo(this);
            Item = item;
        }

        public Item Item { get; set; }

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
