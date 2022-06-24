using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.Models.Notifications;
using Domain.Models.Pipeline;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace DomainTest.Models.Sprints.Close
{
    public class PipeLineBehaviorTest
    {

        [Fact]
        public void ComponentAcceptVisitoryIsCalled()
        {
            var visitor = new Mock<IVisitor>();

            var component = new Mock<IComponent>();
            var components = new List<IComponent>() { component.Object };

            var pipeline = new PipeLineBehavior(components, visitor.Object);

            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);

            pipeline.Close(sprint);
            component.Verify(x => x.Accept(visitor.Object), Times.Exactly(1));
        }

        [Fact]
        public void BuildPipeLine()
        {
            var visitor = new Mock<IVisitor>();
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);

            var buildComponent = new Build(sprint);
            var testComponent = new Test();


            var components = new List<IComponent>()
            {
                buildComponent,
                testComponent,
            };

            var pipeline = new PipeLineBehavior(components, visitor.Object);

            pipeline.Close(sprint);

            visitor.Verify(x => x.VisitBuild(buildComponent), Times.Exactly(1));
            visitor.Verify(x => x.VisitTest(testComponent), Times.Exactly(1));
        }
    }
}
