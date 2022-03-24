using System;
namespace Domain.Models.Pipeline
{
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
