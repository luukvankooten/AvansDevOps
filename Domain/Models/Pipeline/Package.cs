using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Package: IComponent
    {
        public Package()
        {
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPackage(this);
        }
    }
}
