using System;
namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State pattern
    /// </summary>
    public class ReadyForTestingState : IBacklogState
    {
        public ReadyForTestingState(Item context)
        {
            Context = context;
        }

        public Item Context { get; set; }

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
            return this;
        }

        public IBacklogState ReadyForTesting()
        {
            return this;
        }
    }
}
