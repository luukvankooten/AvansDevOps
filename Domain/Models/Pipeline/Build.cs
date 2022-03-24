using System;
using Domain.Models.Notifications;

namespace Domain.Models.Pipeline
{
    public class Build: IComponent
    {
        public bool Failed { get; protected set; } = false;
        public Notifier Notifier { get; }

        public Build(Notifier notifier)
        {
            Notifier = notifier;
        }


        public void BuildFailed()
        {
            Notifier.Notify();
            Failed = true;
            throw new Exception("Build have failed");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitBuild(this);
        }
    }
}
