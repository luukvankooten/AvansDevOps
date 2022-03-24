using System;
namespace Domain.Models.BacklogPhases
{
    public class ReadyForTestingState : IBacklogState
    {
        public ReadyForTestingState(BacklogContext context)
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

        public IBacklogState Tested()
        {
            return this;
        }

        public IBacklogState Testing()
        {
            return new TestingState(Context);
        }

        public IBacklogState Todo()
        {
            Context.Notifier.Notify();
            return new TodoState(Context);
        }

        public IBacklogState ReadyForTesting()
        {
            return this;
        }
    }
}
