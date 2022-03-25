using System;
namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State pattern
    /// </summary>
    public class TestingState : IBacklogState
    {
        public TestingState(BacklogContext context)
        {
            Context = context;
        }

        public BacklogContext Context { get; set; }

       
        public IBacklogState Doing()
        {
            return this;
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
            return new TestedState(Context);
        }

        public IBacklogState Todo()
        {
            Context.Notifier.Notify();
            return new TodoState(Context);
        }

        public IBacklogState Testing()
        {
            return this;
        }
    }
}
