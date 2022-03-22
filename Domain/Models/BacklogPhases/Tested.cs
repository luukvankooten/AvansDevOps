using System;
namespace Domain.Models.BacklogPhases
{
    public class Tested : IBacklogState
    {
        public Item Item { get; set; }

        public Tested(Item item)
        {
            Item = item;
        }

        public IBacklogState Doing()
        {
            throw new NotImplementedException();
        }

        public IBacklogState Done()
        {
            throw new NotImplementedException();
        }

        public IBacklogState ReadyForTesting()
        {
            throw new NotImplementedException();
        }

        public IBacklogState Testing()
        {
            throw new NotImplementedException();
        }

        public IBacklogState Todo()
        {
            throw new NotImplementedException();
        }

        IBacklogState IBacklogState.Tested()
        {
            throw new NotImplementedException();
        }
    }
}
