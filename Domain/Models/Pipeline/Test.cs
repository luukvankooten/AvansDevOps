using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Test : IComponent
    {
        public double TestCoverage { get; set; } = 0;

        public Test()
        {
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTest(this);
        }
    }
}
