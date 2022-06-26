using System;
namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State pattern
    /// </summary>
    public class TodoState : IBacklogState
    {
        public Item Context { get; set; }

        public TodoState(Item context)
        {
            Context = context;
        }

        public IBacklogState Doing()
        {
            return new DoingState(Context);
        }

        public IBacklogState Done()
        {
            return this;
        }

        public IBacklogState ReadyForTesting()
        {
            return this;
        }

        public IBacklogState Tested()
        {
            return this;
        }

        public IBacklogState Testing()
        {
            return this;
        }

        public IBacklogState Todo()
        {
            return this;
        }
    }
}
