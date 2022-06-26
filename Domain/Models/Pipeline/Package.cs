using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Package: PipelinePhase
    {
        public Package()
        {
        }
        

        protected override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
