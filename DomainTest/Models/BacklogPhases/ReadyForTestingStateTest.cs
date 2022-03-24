using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Domain.Models.Notifications;
using Moq;
using Xunit;

namespace Domain.Test.Models.BacklogPhases
{
    public class ReadyForTestingStateTest
    {

        [Fact]
        public void SwitchStateToTodo()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Mock<Notifier>();
            var context = new BacklogContext(item, notifier.Object);
            var state = new ReadyForTestingState(context);

            var newState = state.Todo();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToDoing()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Mock<Notifier>();
            var context = new BacklogContext(item, notifier.Object);
            var state = new ReadyForTestingState(context);

            var newState = state.Doing();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToReadyForTesting()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Mock<Notifier>();
            var context = new BacklogContext(item, notifier.Object);
            var state = new ReadyForTestingState(context);

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
            var notifier = new Mock<Notifier>();
            var context = new BacklogContext(item, notifier.Object);
            var state = new ReadyForTestingState(context);

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
            var notifier = new Mock<Notifier>();
            var context = new BacklogContext(item, notifier.Object);
            var state = new ReadyForTestingState(context);

            var newState = state.Tested();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToDone()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var notifier = new Mock<Notifier>();
            var context = new BacklogContext(item, notifier.Object);
            var state = new ReadyForTestingState(context);

            var newState = state.Done();

            Assert.IsType<ReadyForTestingState>(newState);
        }
    }
}
