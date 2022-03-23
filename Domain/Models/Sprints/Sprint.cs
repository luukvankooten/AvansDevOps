using System;
using System.Collections.Generic;
using Domain.Models.Sprints.Actions;

namespace Domain.Models.Sprints
{

    /// <summary>
    /// Visitor pattern
    /// </summary>
    public abstract class Sprint
    {
        public Sprint(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster)
        {
            Name = name;
            StartTime = startTime;
            EndDate = endDate;
            LeadDeveloper = leadDeveloper;
            ScrumMaster = scrumMaster;
        }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public IList<Item> Items { get; set; } = new List<Item>();

        public Member ScrumMaster { get; set; }

        public Member LeadDeveloper { get; set; }
    }
}
