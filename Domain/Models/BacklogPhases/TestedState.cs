using System;
namespace Domain.Models.BacklogPhases
{
    public class TestedState : IBacklogState
    {
        public TestedState(BacklogContext context)
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
            return new DoneState(Context);
        }

        public IBacklogState ReadyForTesting()
        {
            return new ReadyForTestingState(Context);
        }

        public IBacklogState Testing()
        {
            return this;
        }

        public IBacklogState Todo()
        {
            return this;
        }

        public IBacklogState Tested()
        {
            return this;
        }
    }
}
