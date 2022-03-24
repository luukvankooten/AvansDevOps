using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Xunit;
using Moq;
using Domain.Models.Notifications;

namespace DomainTest.Models.BacklogPhases
{
    public class DoingStateTest
    {

        [Fact]
        public void SwitchStateToTodo()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);
            var state = new DoingState(context);

            var newState = state.Todo();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateToDoing()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);
            var state = new DoingState(context);

            var newState = state.Doing();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateToReadyForTesting()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);
            var state = new DoingState(context);

            var newState = state.ReadyForTesting();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToTesting()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);
            var state = new DoingState(context);

            var newState = state.Testing();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateTested()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var developer = new Member("Foo", "foo");
            var item = new Item(developer, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);
            var state = new DoingState(context);

            var newState = state.Tested();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateToDone()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);
            var state = new DoingState(context);

            var newState = state.Done();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void TesterMustRecieveNotification()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);

            var observer = new Mock<IObserver>();

            notifier.AddObserver(observer.Object);

            var context = new BacklogContext(item, notifier);
            var state = new DoingState(context);

            state.ReadyForTesting();

            observer.Verify(x => x.Update(sprint), Times.Exactly(1));
        }

    }
}
