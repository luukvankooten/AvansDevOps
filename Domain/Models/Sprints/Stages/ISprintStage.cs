using System;
namespace Domain.Models.Sprints.Stages
{
    /// <summary>
    /// Part of the state pattern
    /// </summary>
    public interface ISprintStage
    {
        ISprintStage Create();

        ISprintStage Execute();

        ISprintStage Finish();

        ISprintStage Close();

        ISprintStage Cancel();
    }
}
