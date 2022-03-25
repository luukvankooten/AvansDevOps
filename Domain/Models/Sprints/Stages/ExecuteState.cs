using System;
namespace Domain.Models.Sprints.Stages
{
    /// <summary>
    /// Part of the state pattern
    /// </summary>
    public class ExecuteState: ISprintStage
    {
        public ExecuteState(SprintContext sprintContext)
        {
            SprintContext = sprintContext;
        }

        public SprintContext SprintContext { get; }

        public ISprintStage Cancel()
        {
            return this;
        }

        public ISprintStage Close()
        {
            return this;
        }

        public ISprintStage Create()
        {
            return this;
        }

        public ISprintStage Execute()
        {
            return this;
        }

        public ISprintStage Finish()
        {
            return new FinishState(SprintContext);
        }
    }
}
