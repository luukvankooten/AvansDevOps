using System;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Stages;
using Domain.Models.Sprints;
using Domain.Models;
using Xunit;
using Moq;
using Domain.Models.Sprints.Close;

namespace DomainTest.Models.Sprints.Stages
{
    public class CloseStateTest
    {
        [Fact]
        public void SwitchStateToCreate()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CloseState(context);

            var newState = state.Create();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void SwitchStateToExecute()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CloseState(context);

            var newState = state.Execute();

            Assert.IsType<CloseState>(newState);
        }


        [Fact]
        public void SwitchStateToFinish()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CloseState(context);

            var newState = state.Finish();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void SwitchStateToClose()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CloseState(context);

            var newState = state.Close();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void SwitchStateToCancel()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CloseState(context);

            var newState = state.Cancel();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void CloseBehaviorCallTest()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);

            var behavior = new Mock<ICloseBehavior>();
            var context = new Mock<SprintContext>(MockBehavior.Loose, sprint, behavior.Object, notifier);

            var state = new CloseState(context.Object);

            state.Close();

            behavior.Verify(x => x.Close(context.Object.Sprint), Times.Exactly(1));
        }

    }
}
