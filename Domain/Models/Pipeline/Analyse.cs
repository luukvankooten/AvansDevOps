using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Analyse: IComponent
    {
        public Analyse()
        {
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitAnalyse(this);
        }
    }
}
