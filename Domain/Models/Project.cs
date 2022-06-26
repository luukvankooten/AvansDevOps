using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Project
    {
        public Project(Member productOwner)
        {
            ProductOwner = productOwner;
        }

        public IList<Sprint> Sprints { get; set; } = new List<Sprint>();

        public Member ProductOwner { get; set; }

        public string SCM { get; set; }

    }
}
