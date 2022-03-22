using System;
namespace Domain.Models.BacklogPhases
{
    public class Done : IBacklogState
    {
        public Done(BacklogContext context)
        {
            Context = context;
        }

        public BacklogContext Context { get; set; }

        public IBacklogState Doing()
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

        public IBacklogState Todo()
        {
            return this;
        }

        IBacklogState IBacklogState.Done()
        {
            return this;
        }
    }
}
