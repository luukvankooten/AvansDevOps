using System;
using System.Collections.Generic;
using Domain.Models.Pipeline;

namespace Domain.Models.Sprints.Close
{
    public class PipeLineBehavior: ICloseBehavior
    {
        public PipeLineBehavior(IList<PipelinePhase> pipelinePhase)
        {
            PipelinePhase = pipelinePhase;
        }

        public IList<PipelinePhase> PipelinePhase { get; }

        public void Close(Sprint sprint)
        {
            foreach(PipelinePhase component in PipelinePhase)
            {
                component.Execute();
            }
        }
    }
}
