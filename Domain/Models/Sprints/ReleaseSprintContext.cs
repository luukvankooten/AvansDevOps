using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints.Stages;

namespace Domain.Models.Sprints
{
    /// <summary>
    /// Release sprint are always closed with pipeLineBehavior.
    /// </summary>
    public class ReleaseSprintContext : SprintContext
    {
        public ReleaseSprintContext(CreateState sprintStage, PipeLineBehavior pipeLineBehavior, Notifier notifier) : base(sprintStage, pipeLineBehavior, notifier)
        {
        }
    }
}