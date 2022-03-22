using System;
namespace Domain.Models.BacklogPhases
{
    public class Testing : IBacklogState
    {
        public BacklogContext Context { get; set; }

        

        public IBacklogState Doing()
        {
            return new ReadyForTesting(Item);
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
            return new Todo(Item);
        }

        IBacklogState IBacklogState.Testing()
        {
            return new Tested(Item);
        }
    }
}
