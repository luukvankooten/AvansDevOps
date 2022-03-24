using System;
namespace Domain.Models.Sprints.Stages
{
    public class FinishState: ISprintStage
    {
        public FinishState(SprintContext context)
        {
            Context = context;
        }

        public SprintContext Context { get; }

        public ISprintStage Cancel()
        {
            return this;
        }

        public ISprintStage Close()
        {
            return new CloseState(Context);
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
