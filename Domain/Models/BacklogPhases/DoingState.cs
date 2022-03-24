using System;
namespace Domain.Models.BacklogPhases
{
    public class DoingState : IBacklogState
    {
        public DoingState(BacklogContext context)
        {
            Context = context;
        }

        public BacklogContext Context { get; set; }


        public IBacklogState Done()
        {
            return this;
        }

        public IBacklogState ReadyForTesting()
        {
            Context.Notifier.Notify();
            return new ReadyForTestingState(Context);
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

        public IBacklogState Doing()
        {
            return this;
        }
    }
}
