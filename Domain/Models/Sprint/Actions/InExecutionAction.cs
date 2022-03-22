using System;
namespace Domain.Models.Sprint.Actions
{
    public class ConcreteExecuteAction: IAction
    {
        public ConcreteExecuteAction()
        {
        }

        public void Dispatch(Sprint sprint)
        {
            throw new NotImplementedException();
        }
    }
}
