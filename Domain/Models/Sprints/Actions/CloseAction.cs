using System;
namespace Domain.Models.Sprints.Actions
{
    public class CloseAction : IAction
    {
        public CloseAction()
        {
        }

        Sprint IAction.Dispatch(Sprint sprint)
        {
            // TODO: Close
            throw new NotImplementedException();
        }
    }
}
