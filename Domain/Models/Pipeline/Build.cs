using System;
using Domain.Models.Notifications;

namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Template pattern
    /// </summary>
    public class Build: PipelinePhase
    {
        public Sprint Sprint { get; }
        public bool Failed { get; set; } = false;

        public Build(Sprint sprint)
        {
            Sprint = sprint;
        }

        protected override void Run()
        {
            if (Failed)
            {
                Member[] members = { Sprint.Project.ProductOwner, Sprint.LeadDeveloper  };
                Sprint.Notify(members,"The build has failed");
                Failed = true;
                throw new Exception("Build has failed");
            }
        }
    }
}
