using System;
namespace Domain.Models.Sprints.Stages
{
    public interface ISprintStage
    {
        ISprintStage Create();

        ISprintStage Execute();

        ISprintStage Finish();

        ISprintStage Close();

        ISprintStage Cancel();
    }
}
