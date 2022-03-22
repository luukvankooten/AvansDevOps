using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Project
    {
        public Project(IList<Sprint> sprints, Member productOwner)
        {
            Sprints = sprints;
            ProductOwner = productOwner;
        }

        public IList<Sprint> Sprints { get; set; }

        public Member ProductOwner { get; set; }

    }
}
