using System;
namespace Domain.Models.Sprint
{
    public abstract class SprintContext
    {

        public Sprint? Sprint { private set; get; }

        public Actions.IAction Action { get; set; }


        public SprintContext(Actions.IAction action)
        {
            Action = action;
        }

        public void PerformDispatch()
        {
            Sprint = Action.Dispatch();
        }
    }
}
