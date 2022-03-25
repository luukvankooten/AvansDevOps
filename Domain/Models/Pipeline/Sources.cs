using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
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
