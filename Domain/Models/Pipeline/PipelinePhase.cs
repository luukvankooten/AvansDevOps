using System;

namespace Domain.Models.Pipeline
{
    public abstract class PipelinePhase
    {
        public void Execute()
        {
            Start();
            Run();
            Finish();
        }
        
        protected virtual void HookStart()
        {
        }


        protected void Start()
        {
            HookStart();
            //Gedaan worden
            Console.WriteLine("New piplinephase has started");
        }

        protected abstract void Run();

        protected void Finish()
        {
            Console.WriteLine("pipelinephase has finished");
        }
    }
}