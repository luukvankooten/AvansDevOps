using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace Domain.Test.Models.BacklogPhases
{
    public class ReadyForTestingStateTest
    {

        [Fact]
        public void SwitchStateToTodo()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, member, "bar", sprint);
            var state = new ReadyForTestingState(context);

            var newState = state.Todo();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToDoing()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, member, "bar", sprint);
            var state = new ReadyForTestingState(context);

            var newState = state.Doing();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToReadyForTesting()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, member, "bar", sprint);
            var state = new ReadyForTestingState(context);

            var newState = state.ReadyForTesting();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToTesting()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, member, "bar", sprint);
            var state = new ReadyForTestingState(context);

            var newState = state.Testing();

            Assert.IsType<TestingState>(newState);
        }

        [Fact]
        public void SwitchStateTested()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, member, "bar", sprint);
            var state = new ReadyForTestingState(context);

            var newState = state.Tested();

            Assert.IsType<ReadyForTestingState>(newState);
        }

        [Fact]
        public void SwitchStateToDone()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, member, "bar", sprint);
            var state = new ReadyForTestingState(context);

            var newState = state.Done();

            Assert.IsType<ReadyForTestingState>(newState);
        }
    }
}
