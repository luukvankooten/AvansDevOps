using System;
namespace Domain.Models.BacklogPhases
{
    public class TestingState : IBacklogState
    {
        public TestingState(BacklogContext context)
        {
            Context = context;
        }

        public BacklogContext Context { get; set; }

       
        public IBacklogState Doing()
        {
            return new ReadyForTestingState(Context);
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

        public IBacklogState Todo()
        {
            return new TotoState(Context);
        }

        public IBacklogState Testing()
        {
            return new TestedState(Context);
        }
    }
}
