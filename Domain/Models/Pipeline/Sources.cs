using System;
namespace Domain.Models.Pipeline
{
    public class Sources: IComponent
    {
        public Sources()
        {
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSources(this);
        }
    }
}
