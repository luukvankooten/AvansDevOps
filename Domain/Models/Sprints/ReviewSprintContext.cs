using Domain.Models.Sprints.Actions;
namespace Domain.Models.Sprints
{
    public class ReviewSprintContext : SprintContext
    {
        public ReviewSprintContext(IAction action)
            : base(action) { }
    }
}