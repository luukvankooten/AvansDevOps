using System;
namespace Domain.Models.BacklogPhases
{
    public class DoneState : IBacklogState
    {
        public DoneState(BacklogContext context)
        {
            Context = context;
        }

        public BacklogContext Context { get; set; }

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
            return this;
        }

        public IBacklogState Done()
        {
            return this;
        }
    }
}
