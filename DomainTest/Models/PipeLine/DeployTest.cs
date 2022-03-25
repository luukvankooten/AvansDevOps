using System;
using Domain.Models.Pipeline;
using Domain.Models;
using Moq;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class DeployTest
    {
        [Fact]
        public void AcceptsVisotorTest()
        {
            var visitor = new Mock<IVisitor>();
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);

            var component = new Deploy();

            component.Accept(visitor.Object);

            visitor.Verify(x => x.VisitDeploy(component), Times.Exactly(1));
        }

    }
}
