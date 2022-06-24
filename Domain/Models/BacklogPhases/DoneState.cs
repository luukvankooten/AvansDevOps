using System;
namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State pattern
    /// </summary>
    public class DoneState : IBacklogState
    {
        public DoneState(Item context)
        {
            Context = context;
        }

        public Item Context { get; set; }

        public IBacklogState Doing()
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
            return new TodoState(Context);
        }

        public IBacklogState Done()
        {
            return this;
        }
    }
}
