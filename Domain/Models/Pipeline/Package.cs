using System;
namespace Domain.Models.Pipeline
{
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
