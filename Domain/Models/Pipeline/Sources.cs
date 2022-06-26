using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public class Sources: PipelinePhase
    {
        protected override void Run()
        {
               //Activiteiten om de source code die gebouwd (en mogelijk getest en gedeployed) moet worden op te halen naar een context waarin de gehele pipeline wordt uitgevoerd.
            Console.WriteLine("Collecting sources");       
        }
    }
}
