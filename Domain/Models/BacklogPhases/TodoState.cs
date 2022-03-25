using System;
namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State pattern
    /// </summary>
    public class TodoState : IBacklogState
    {
        public BacklogContext Context { get; set; }

        public TodoState(BacklogContext context)
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
