using System;
namespace Domain.Models.BacklogPhases
{
    public interface IBacklogState
    {
        IBacklogState Todo();

        IBacklogState Doing();

        IBacklogState ReadyForTesting();

        IBacklogState Testing();

        IBacklogState Tested();

        IBacklogState Done();
    }
}
