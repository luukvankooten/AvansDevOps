using Domain.Models.Pipeline;
using Moq;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class SourcesTest
    {
        public SourcesTest()
        {
        }

        [Fact]
        public void AcceptsVisotorTest()
        {
            var visitor = new Mock<IVisitor>();
            var component = new Sources();

            component.Accept(visitor.Object);

            visitor.Verify(x => x.VisitSources(component), Times.Exactly(1));
        }
    }
}
