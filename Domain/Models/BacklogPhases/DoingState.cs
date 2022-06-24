using System;
namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State pattern
    /// </summary>
    public class DoingState : IBacklogState
    {
        public DoingState(Item context)
        {
            Context = context;
        }

        public Item Context { get; set; }


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
