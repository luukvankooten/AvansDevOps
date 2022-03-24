using System;
using Domain.Models.Sprints.Close;

namespace Domain.Models.Sprints.Stages
{
    public class CloseState: ISprintStage
    {
        public CloseState(SprintContext sprintContext)
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
            SprintContext.CloseBehavior.Close(SprintContext.Sprint);
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
