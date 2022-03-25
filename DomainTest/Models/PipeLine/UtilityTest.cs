using Domain.Models.Pipeline;
using Moq;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class UtilityTest
    {
        public UtilityTest()
        {
        }

        [Fact]
        public void AcceptsVisotorTest()
        {
            var visitor = new Mock<IVisitor>();
            var component = new Utility();

            component.Accept(visitor.Object);

            visitor.Verify(x => x.VisitUtitily(component), Times.Exactly(1));
        }
    }
}
