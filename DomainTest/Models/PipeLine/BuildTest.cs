using System;
using Domain.Models;
using Domain.Models.Notifications;
using Domain.Models.Pipeline;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class BuildTest
    {

        [Fact]
        public void AcceptsVisotorTest()
        {
            var visitor = new Mock<IVisitor>();
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var component = new Build(sprint);

            component.Accept(visitor.Object);

            visitor.Verify(x => x.VisitBuild(component), Times.Exactly(1));
        }

        [Fact]
        public void BuildFailedShouldRaiseError()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var component = new Build(sprint);

            var observer = new Mock<ISprintObserver>();

            sprint.AddObserver(observer.Object);

            Assert.Throws<Exception>(() => component.BuildFailed());

            observer.Verify(x => x.Update(sprint), Times.Exactly(1));

            Assert.True(component.Failed);
        }
    }
}
