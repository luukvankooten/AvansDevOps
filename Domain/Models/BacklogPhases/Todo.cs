using System;
namespace Domain.Models.BacklogPhases
{
    public class Todo : IBacklogState
    {
        public BacklogContext Context { get; set; }

        public Todo(BacklogContext context)
        {
            Context = context;
        }

        public IBacklogState Doing()
        {
            return new Doing(Item);
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

        public IBacklogState Testing()
        {
            return this;
        }

        IBacklogState IBacklogState.Todo()
        {
            return this;
        }
    }
}
