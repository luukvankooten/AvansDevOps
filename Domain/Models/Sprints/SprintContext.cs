using System;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints.Stages;

namespace Domain.Models.Sprints
{

    /// <summary>
    /// Use the state pattern and the Strategy pattern
    /// </summary>
    public abstract class SprintContext
    {

        public Sprint Sprint { get; }
        public ICloseBehavior CloseBehavior { get; set; }
        public Notifier Notifier { get; }
        public ISprintStage SprintStage { get; protected set; }

        public SprintContext(CreateState sprintStage, ICloseBehavior closeBehavior, Notifier notifier)
        {
            SprintStage = sprintStage;
            Sprint = sprintStage.Sprint;
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

        public virtual void Close()
        {
            SprintStage = SprintStage.Close();
        }

    }
}
