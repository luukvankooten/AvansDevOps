using System;
namespace Domain.Models.BacklogPhases
{
    /// <summary>
    /// State pattern
    /// </summary>
    public class TestingState : IBacklogState
    {
        public TestingState(Item context)
        {
            Context = context;
        }

        public Item Context { get; set; }

       
        public IBacklogState Doing()
        {
            Member[] members = { Context.Sprint.ScrumMaster };
            Context.Notify(members, "Cannot move back to doing");
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
            return new TodoState(Context);
        }

        public IBacklogState Testing()
        {
            return this;
        }
    }
}
