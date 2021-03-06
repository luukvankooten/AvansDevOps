using System;
namespace Domain.Models.Sprints.Stages
{
    /// <summary>
    /// Part of the state pattern
    /// </summary>
    public class ExecuteState: ISprintStage
    {
        public ExecuteState(Sprint context)
        {
            Context = context;
        }

        public Sprint Context { get; }

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
            return new FinishState(Context);
        }
    }
}
