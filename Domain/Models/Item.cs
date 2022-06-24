using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models.BacklogPhases;
using Domain.Models.Discussions;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Stages;

namespace Domain.Models
{
    public class Item : Notifier
    {
        public Item(Member developer, string description, Sprint sprint)
        {
            Developer = developer;
            Description = description;
            Sprint = sprint;
            ThreadDiscussion = new ThreadDiscussion(this);
            State = new TodoState(this);
            sprint.AddItem(this);
        }

        protected Item(Member developer, string description, Item item)
        {
            Description = description;
            Developer = developer;
            Sprint = item.Sprint;
            State = item.State;
        }

        public Member Developer { get; set; }

        public string Description { get; protected set; }

        public IBacklogState State { get; set; }

        public Sprint Sprint { get; set; }

        public IList<Item> SubItems { get; set; } = new List<Item>();

        public ThreadDiscussion ThreadDiscussion { get; }

        public Item AddSubItem(Member member, string description)
        {
            if(Sprint.SprintStage is not CreateState)
            {
                throw new InvalidOperationException("The sprint has already started");
            }

            var item = new Item(member, description, this);

            SubItems.Add(item);

            return item;
        }

        public void SetDescription(string description)
        {
            if(Sprint.SprintStage is not CreateState)
            {
                throw new InvalidOperationException("The sprint has already started");
            }

            Description = description;
        }        

        public void Doing()
        {
            State = State.Doing();
        }

        public void Done()
        {
            State = State.Done();
        }

        public void ReadyForTesting()
        {
            State = State.ReadyForTesting();
        }

        public void Tested()
        {
            State = State.Tested();
        }

        public void Testing()
        {
            State = State.Testing();
        }

        public void Todo()
        {
            State = State.Todo();
        }

        protected override void Update(ISprintObserver observer)
        {
            observer.Update(this);
        }
    }
}
