using System;
namespace Domain.Models.Pipeline
{
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
