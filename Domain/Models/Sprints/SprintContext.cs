using Domain.Models.Sprints.Actions;

namespace Domain.Models.Sprints
{
    public abstract class SprintContext
    {

        public Sprint Sprint { private set; get; }

        public IAction Action { get; set; }


        public SprintContext(IAction action)
        {
            Action = action;
        }

        public void PerformDispatch()
        {
            Sprint = Action.Dispatch(Sprint);
        }
    }
}
