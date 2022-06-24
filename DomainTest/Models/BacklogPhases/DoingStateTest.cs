using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Xunit;
using Moq;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;

namespace DomainTest.Models.BacklogPhases
{
    public class DoingStateTest
    {

        [Fact]
        public void SwitchStateToTodo()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new DoingState(context);

            var newState = state.Todo();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateToDoing()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new DoingState(context);

            var newState = state.Doing();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateToReadyForTesting()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new DoingState(context);

            var newState = state.ReadyForTesting();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToTesting()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new DoingState(context);

            var newState = state.Testing();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateTested()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new DoingState(context);

            var newState = state.Tested();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateToDone()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new DoingState(context);

            var newState = state.Done();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void TesterMustRecieveNotification()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);

            var observer = new Mock<ISprintObserver>();

            context.AddObserver(observer.Object);

            var state = new DoingState(context);

            state.ReadyForTesting();

            observer.Verify(x => x.Update(sprint), Times.Exactly(1));
        }

    }
}
