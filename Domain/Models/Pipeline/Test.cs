using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Test : PipelinePhase
    {
        public double TestCoverage { get; set; } = 0;

        public Test()
        {
        }

        protected override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
