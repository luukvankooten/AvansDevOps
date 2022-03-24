using System;
namespace Domain.Models.Pipeline
{
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
