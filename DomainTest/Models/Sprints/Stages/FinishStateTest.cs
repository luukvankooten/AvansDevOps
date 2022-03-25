using System;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Stages;
using Domain.Models.Sprints;
using Domain.Models;
using Xunit;
using Domain.Models.Sprints.Close;
using Moq;

namespace DomainTest.Models.Sprints.Stages
{
    public class FinishStateTest
    {
        [Fact]
        public void SwitchStateToCreate()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new FinishState(context);

            var newState = state.Create();

            Assert.IsType<FinishState>(newState);
        }

        [Fact]
        public void SwitchStateToExecute()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new FinishState(context);

            var newState = state.Execute();

            Assert.IsType<FinishState>(newState);
        }


        [Fact]
        public void SwitchStateToFinish()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new FinishState(context);

            var newState = state.Finish();

            Assert.IsType<FinishState>(newState);
        }

        [Fact]
        public void SwitchStateToClose()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Document());
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new FinishState(context);

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
            var state = new FinishState(context);

            var newState = state.Cancel();

            Assert.IsType<CancelState>(newState);
        }


        [Fact]
        public void SwitchStateToCloseShouldRecieveNotification()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);

            var observer = new Mock<IObserver>();

            notifier.AddObserver(observer.Object);

            var behavior = new Mock<ICloseBehavior>();
            var context = new Mock<SprintContext>(MockBehavior.Loose, sprint, behavior.Object, notifier);

            var state = new FinishState(context.Object);

            state.Cancel();

            observer.Verify(x => x.Update(sprint), Times.Exactly(1));
        }

    }
}
