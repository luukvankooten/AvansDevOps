using System;
using System.Collections.Generic;
using Domain.Models.BacklogPhases;

namespace Domain.Models
{
    public class Item
    {
        public Item(Member developer, string description, Sprint sprint)
        {
            Developer = developer;
            Description = description;
            Sprint = sprint;
            sprint.Items.Add(this);
        }

        public Member Developer { get; set; }

        public string Description { get; set; }

        public Sprint Sprint { get; set; }

        public IList<Item> SubItems { get; } = new List<Item>();
    }
}
