using System;
using Domain.Models;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints.Stages;
using Moq;
using Xunit;

namespace DomainTest.Models.Sprints.Stages
{
    public class ExecuteStateTest
    {
        [Fact]
        public void SwitchStateToCreate()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var state = new ExecuteState(context);

            var newState = state.Create();

            Assert.IsType<ExecuteState>(newState);
        }

        [Fact]
        public void SwitchStateToExecute()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);

            var state = new ExecuteState(context);

            var newState = state.Execute();

            Assert.IsType<ExecuteState>(newState);
        }


        [Fact]
        public void SwitchStateToFinish()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);

            var state = new ExecuteState(context);

            var newState = state.Finish();

            Assert.IsType<FinishState>(newState);
        }

        [Fact]
        public void SwitchStateToClose()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var state = new ExecuteState(context);

            var newState = state.Close();

            Assert.IsType<ExecuteState>(newState);
        }

        [Fact]
        public void SwitchStateToCancel()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);

            var state = new ExecuteState(context);

            var newState = state.Cancel();

            Assert.IsType<ExecuteState>(newState);
        }
    }
}
