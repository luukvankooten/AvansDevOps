using Domain.Models.Pipeline;
using Moq;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class AnalyseTest
    {

        [Fact]
        public void AcceptsVisotorTest()
        {
            var visitor = new Mock<IVisitor>();
            var component = new Analyse();

            component.Accept(visitor.Object);

            visitor.Verify(x => x.VisitAnalyse(component), Times.Exactly(1));
        }
    }
}
