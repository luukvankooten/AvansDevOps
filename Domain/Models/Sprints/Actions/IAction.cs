namespace Domain.Models.Sprints.Actions
{
    public interface IAction
    {
        Sprint Dispatch(Sprint sprint);
    }
}
