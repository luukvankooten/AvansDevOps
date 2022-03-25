using System;
namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State pattern
    /// </summary>
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
            Context.ThreadDiscussion.IsClosed = false;
            return new TodoState(Context);
        }

        public IBacklogState Done()
        {
            return this;
        }
    }
}
