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
            return this;
        }

        public IBacklogState Done()
        {
            return this;
        }

        public IBacklogState ReadyForTesting()
        {
            return new ReadyForTestingState(Context);
        }

        public IBacklogState Tested()
        {
            return this;
        }

        public IBacklogState Todo()
        {
            return this;
        }

        public IBacklogState Testing()
        {
            return this;
        }
    }
}
