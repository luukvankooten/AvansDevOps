using Domain.Models.Pipeline;
using Moq;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class PackageTest
    {
        [Fact]
        public void AcceptsVisotorTest()
        {
            var visitor = new Mock<IVisitor>();
            var component = new Package();

            component.Accept(visitor.Object);

            visitor.Verify(x => x.VisitPackage(component), Times.Exactly(1));
        }
    }
}
