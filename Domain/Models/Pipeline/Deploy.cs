using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
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
