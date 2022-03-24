using System;
namespace Domain.Models.Pipeline
{
    public class Deploy: IComponent
    {
        public Deploy()
        {
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitDeploy(this);
        }
    }
}
