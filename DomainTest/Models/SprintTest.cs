using System;
using Domain.Models;
using Domain.Models.Notifications;
using Domain.Models.Sprints;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints.Stages;
using Moq;
using Xunit;

namespace DomainTest.Models
{
    public class SprintTest
    {
        [Fact]
        public void SprintContextHappyStateTest()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);

            context.Create();

            Assert.IsType<CreateState>(context.SprintStage);

            context.Execute();

            Assert.IsType<ExecuteState>(context.SprintStage);

            context.Finish();

            Assert.IsType<FinishState>(context.SprintStage);

            context.Close();

            Assert.IsType<CloseState>(context.SprintStage);
        }

        [Fact]
        public void SprintContextCancelStateTest()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);

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
