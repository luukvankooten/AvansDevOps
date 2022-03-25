using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Utility: IComponent
    {
        public Utility()
        {
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitUtitily(this);
        }
    }
}
