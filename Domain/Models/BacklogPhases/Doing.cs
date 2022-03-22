using System;
namespace Domain.Models.BacklogPhases
{
    public class Doing : IBacklogState
    {
        public Doing(BacklogContext context)
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

        IBacklogState IBacklogState.Doing()
        {
            return new ReadyForTesting(Context);
        }
    }
}
