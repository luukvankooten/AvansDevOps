using System;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints.Stages;

namespace Domain.Models.Sprints
{

    /// <summary>
    /// Part of the state pattern and strattergy
    /// </summary>
    public class SprintContext
    {

        public Sprint Sprint { get; }
        public ICloseBehavior CloseBehavior { get; set; }
        public Notifier Notifier { get; }
        public ISprintStage SprintStage { get; protected set; }

        public SprintContext(Sprint sprint, ICloseBehavior closeBehavior, Notifier notifier)
        {
            var cSprint = new Sprint(sprint);
            SprintStage = new CreateState(this, cSprint);
            Sprint = cSprint;
            CloseBehavior = closeBehavior;
            Notifier = notifier;
        }

        public void Create()
        {
            SprintStage = SprintStage.Create();
        }

        public void Execute()
        {
            SprintStage = SprintStage.Execute();
        }

        public void Finish()
        {
            SprintStage = SprintStage.Finish();
        }

        public void Cancel()
        {
            SprintStage = SprintStage.Cancel();
        }

        public void Close()
        {
            SprintStage = SprintStage.Close();
        }

    }
}
