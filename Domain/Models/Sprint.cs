using System;
using System.Collections.Generic;
using Domain.Models.Notifications;
using Domain.Models.Sprints;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints.Stages;

namespace Domain.Models
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Sprint : Notifier
    {
        public Sprint(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, ICloseBehavior closeBehavior, Document document = null)
        {
            Name = name;
            StartTime = startTime;
            EndDate = endDate;
            LeadDeveloper = leadDeveloper;
            ScrumMaster = scrumMaster;
            CloseBehavior = closeBehavior;
            Document = document;
            SprintStage = new CreateState(this);
        }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();

        public Member ScrumMaster { get; set; }
        public ICloseBehavior CloseBehavior { get; }
        public Document Document { get; set; }

        public ISprintStage SprintStage { get; protected set; }

        public Member LeadDeveloper { get; set; }

        public void AddItem(Item item)
        {
            if(SprintStage is not CreateState)
            {
                throw new InvalidOperationException("Cannot add backlog item due to ");
            }

            if(Items.Contains(item))
            {
                throw new InvalidOperationException("Already in backlog");
            }

            Items.Add(item);
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

        protected override void Update(ISprintObserver observer)
        {
            observer.Update(this);
        }
    }
}
