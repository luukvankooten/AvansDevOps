using System;
namespace Domain.Models.Sprints.Stages
{
    public class CreateState: ISprintStage
    {

        public Sprint Sprint { get; }

        public CreateState(SprintContext sprintContext, Sprint sprint)
        {
            SprintContext = sprintContext;
            Sprint = new Sprint(sprint);
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
            return new ExecuteState(SprintContext);
        }

        public ISprintStage Finish()
        {
            return this;
        }
    }
}
