using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Domain.Models.Notifications;
using Moq;
using Xunit;

namespace DomainTest.Models.BacklogPhases
{
    public class TestingStateTest
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
            var state = new TestingState(context);

            var newState = state.Todo();

            Assert.IsType<TodoState>(newState);
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
            var state = new TestingState(context);

            var newState = state.Doing();

            Assert.IsType<TestingState>(newState);
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
            var state = new TestingState(context);

            var newState = state.ReadyForTesting();

            Assert.IsType<TestingState>(newState);
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
            var state = new TestingState(context);

            var newState = state.Testing();

            Assert.IsType<TestingState>(newState);
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
            var state = new TestingState(context);

            var newState = state.Tested();

            Assert.IsType<TestedState>(newState);
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
            var state = new TestingState(context);

            var newState = state.Done();

            Assert.IsType<TestingState>(newState);
        }

        [Fact]
        public void ScrumMasterRecievesNotificationOnSwitchToTodo()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);

            var observer = new Mock<IObserver>();

            notifier.AddObserver(observer.Object);

            var context = new BacklogContext(item, notifier);
            var state = new TestingState(context);

            state.Todo();

            observer.Verify(x => x.Update(sprint), Times.Exactly(1));
        }
    }
}
