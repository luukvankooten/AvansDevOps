using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints.Stages;

namespace Domain.Models.Sprints
{
    /// <summary>
    /// Review sprint is always closed with uploading a document, but could also be closed with a pipeline.
    /// </summary>
    public class ReviewSprintContext : SprintContext
    {

        public Document Document { get; set; }

        public ReviewSprintContext(CreateState sprintStage, Notifier notifier) : base(sprintStage, new ReviewBehavior(), notifier)
        {
        }
    }
}