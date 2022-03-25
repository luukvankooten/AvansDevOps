using Domain.Models.Pipeline;
using Moq;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class TestTest
    {
        [Fact]
        public void AcceptsVisotorTest()
        {
            var visitor = new Mock<IVisitor>();
            var component = new Test();

            component.Accept(visitor.Object);

            visitor.Verify(x => x.VisitTest(component), Times.Exactly(1));
        }
    }
}
