using System;

namespace Domain.Models.Sprints.Actions
{
    public class ChangeAction : IAction
    {
        public ChangeAction(Sprint sprint)
        {
            Sprint = sprint;
        }

        public Sprint Sprint { get; }

        public Sprint Dispatch(Sprint sprint)
        {
            //Sprint has been started and cannot be changed
            if(!(sprint.StartTime >= DateTime.Now))
            {
                sprint.EndDate = Sprint.EndDate;
                sprint.Items = Sprint.Items;
                sprint.LeadDeveloper = Sprint.LeadDeveloper;
                sprint.ScrumMaster = Sprint.ScrumMaster;
                sprint.StartTime = Sprint.StartTime;
            }
            return sprint;
        }
    }
}
