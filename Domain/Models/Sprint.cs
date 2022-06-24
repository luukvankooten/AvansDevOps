using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            SprintStage = new CreateState(this);
            Name = name;
            StartTime = startTime;
            EndDate = endDate;
            LeadDeveloper = leadDeveloper;
            ScrumMaster = scrumMaster;
            CloseBehavior = closeBehavior;
            Document = document;
            
        }

        private string _name;
        public string Name { get => _name;
            set
            {
                isNotCreatedThrows();
                _name = value;
            }
        }

        private DateTime _startTime; 
        public DateTime StartTime { 
            get => _startTime;
            set
            {
                isNotCreatedThrows();

                _startTime = value;
            }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                isNotCreatedThrows();

                _endDate = value;
            }
        }

        public List<Item> Items { get; set; } = new List<Item>();

        private Member _scrumMaster;
        public Member ScrumMaster
        {
            get => _scrumMaster;
            set
            {
                isNotCreatedThrows();

                _scrumMaster = value;
            }
        }

        public ICloseBehavior CloseBehavior { get; }
        public Document Document { get; set; }

        public ISprintStage SprintStage { get; protected set; }

        private Member _leadDeveloper;

        public Member LeadDeveloper
        {
            get => _leadDeveloper;
            set
            {
                isNotCreatedThrows();
                _leadDeveloper = value;
            }
        }

        public void AddItem(Item item)
        {
            isNotCreatedThrows();

            if(Items.Contains(item))
            {
                throw new InvalidOperationException("Already in backlog");
            }

            foreach (var i in Items)
            {
                if (i.SubItems.Contains(item))
                {
                    throw new InvalidOperationException("Already in backlog");
                }
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

        private void isNotCreatedThrows()
        {
            if (SprintStage is not CreateState)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
