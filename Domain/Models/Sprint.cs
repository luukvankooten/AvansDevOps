using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Sprint
    {
        public Sprint(string name, DateTime startDate, DateTime endDate, Member scrumMaster)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            ScrumMaster = scrumMaster;
        }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Member ScrumMaster { get; set; }

        public IList<Item> Items { get; } = new List<Item>();
    }
}
