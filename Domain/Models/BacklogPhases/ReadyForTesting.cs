using System;
namespace Domain.Models.BacklogPhases
{
    public class ReadyForTesting : IBacklogState
    {
        public Item Item { get; set; }
        
        public ReadyForTesting(Item item)
        {
            Item = item;
        }

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
            return this;
        }

        public IBacklogState Todo()
        {
            return this;
        }

        IBacklogState IBacklogState.ReadyForTesting()
        {
            return new Testing(Item);
        }
    }
}
