using System;
namespace Domain.Models.Sprints.Stages
{
    /// <summary>
    /// Part of the state pattern
    /// </summary>
    public class FinishState: ISprintStage
    {
        public FinishState(Sprint context)
        {
            Context = context;
        }

        public Sprint Context { get; }

        public ISprintStage Cancel()
        {
            Context.Notify();
            return new CancelState(Context);
        }

        public ISprintStage Close()
        {
            return new CloseState(Context).Close();
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
