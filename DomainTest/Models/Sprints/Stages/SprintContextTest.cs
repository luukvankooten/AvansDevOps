using System;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints;
using Domain.Models;
using Moq;
using Xunit;
using Domain.Models.Sprints.Stages;

namespace DomainTest.Models.Sprints.Stages
{
    public class SprintContextTest
    {

        [Fact]
        public void SprintContextHappyStateTest()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var behavior = new Mock<ICloseBehavior>();
            var contextMock = new Mock<SprintContext>(MockBehavior.Loose, sprint, behavior.Object, notifier);
            var context = contextMock.Object;

            context.Create();

            Assert.IsType<CreateState>(context.SprintStage);

            context.Execute();

            Assert.IsType<ExecuteState>(context.SprintStage);

            context.Finish();

            Assert.IsType<FinishState>(context.SprintStage);

            context.Close();

            Assert.IsType<FinishState>(context.SprintStage);
        }

        [Fact]
        public void SprintContextCancelStateTest()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var behavior = new Mock<ICloseBehavior>();
            var contextMock = new Mock<SprintContext>(MockBehavior.Loose, sprint, behavior.Object, notifier);
            var context = contextMock.Object;

            context.Create();

            Assert.IsType<CreateState>(context.SprintStage);

            context.Execute();

            Assert.IsType<ExecuteState>(context.SprintStage);

            context.Finish();

            Assert.IsType<FinishState>(context.SprintStage);

            context.Cancel();

            Assert.IsType<CancelState>(context.SprintStage);

        }
    }
}
