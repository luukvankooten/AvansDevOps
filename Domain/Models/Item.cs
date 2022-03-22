using System;
using System.Collections.Generic;
using Domain.Models.BacklogPhases;

namespace Domain.Models
{
    public class Item
    {
        public Item(Member member, string description, Sprint sprint)
        {
            Member = member;
            Description = description;
            Sprint = sprint;
            sprint.Items.Add(this);
        }

        public Member Member { get; set; }

        public string Description { get; set; }

        public Sprint Sprint { get; set; }

        public IList<Item> SubItems { get; } = new List<Item>();
    }
}
