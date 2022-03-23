using System;
namespace Domain.Models.Sprints.Actions
{
    public class ConcreteExecuteAction : IAction
    {
        public ConcreteExecuteAction()
        {
        }

        public Sprint Dispatch(Sprint sprint)
        {
            throw new NotImplementedException();
        }
    }
}
