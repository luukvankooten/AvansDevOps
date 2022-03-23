using Domain.Models.Sprints.Actions;
namespace Domain.Models.Sprints
{
    public class ReleaseSprintContext : SprintContext
    {
        public ReleaseSprintContext(IAction action)
            : base(action) { }
    }
}