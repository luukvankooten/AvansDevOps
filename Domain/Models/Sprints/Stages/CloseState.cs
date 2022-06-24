using System;
using Domain.Models.Sprints.Close;

namespace Domain.Models.Sprints.Stages
{
    /// <summary>
    /// Part of the state pattern
    /// </summary>
    public class CloseState: ISprintStage
    {
        public CloseState(Sprint context)
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
            Context.CloseBehavior.Close(Context);
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
            return this;
        }
    }
}
