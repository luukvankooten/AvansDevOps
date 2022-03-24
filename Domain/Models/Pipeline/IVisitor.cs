using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// This is part of the vistor pattern
    /// </summary>
    public interface IVisitor
    {
        public void VisitSources(Sources analyse);

        public void VisitPackage(Package package);

        public void VisitBuild(Build build);

        public void VisitTest(Test test);

        public void VisitAnalyse(Analyse analyse);

        public void VisitDeploy(Deploy deploy);

        public void VisitUtitily(Utility utility);
    }
}
