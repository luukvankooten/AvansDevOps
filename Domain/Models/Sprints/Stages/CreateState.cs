using System;
namespace Domain.Models.Sprints.Stages
{
    /// <summary>
    /// Part of the state pattern
    /// </summary>
    public class CreateState: ISprintStage
    {

        public Sprint Context { get; }

        public CreateState(Sprint context)
        {
            Context = context;
        }


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
            if(Context.StartTime >= DateTime.Today) {
                return new ExecuteState(Context);
            }

            return this;            
        }

        public ISprintStage Finish()
        {
            return this;
        }
    }
}
