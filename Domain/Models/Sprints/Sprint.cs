using System;
using System.Collections.Generic;

namespace Domain.Models.Sprints
{
    public enum SprintStadium {
        CREATED,
        EXECUTED,
        FINISHED,
        CLOSED,
    }

    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Sprint
    {
        public Sprint(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, Document document = null)
        {
            Name = name;
            StartTime = startTime;
            EndDate = endDate;
            LeadDeveloper = leadDeveloper;
            ScrumMaster = scrumMaster;
            Document = document;
        }

        public Sprint(Sprint sprint)
        {
            Name = sprint.Name;
            StartTime = sprint.StartTime;
            EndDate = sprint.EndDate;
            LeadDeveloper = sprint.LeadDeveloper;
            Items = sprint.Items;
            ScrumMaster = sprint.ScrumMaster;
            SprintStadium = sprint.SprintStadium;
        }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public IList<Item> Items { get; set; } = new List<Item>();

        public Member ScrumMaster { get; set; }
        public Document? Document { get; set; }
        public SprintStadium SprintStadium { get; set; } = SprintStadium.CREATED;

        public Member LeadDeveloper { get; set; }

    }
}
