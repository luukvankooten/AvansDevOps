using System;
using Domain.Models;
using Domain.Models.Notifications;
using Domain.Models.Sprints;
using Domain.Models.Sprints.Stages;
using Xunit;

namespace DomainTest.Models.Sprints.Stages
{
    public class CreateStateTest
    {

        [Fact]
        public void SwitchStateToCreate()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CreateState(context, sprint);

            var newState = state.Create();

            Assert.IsType<CreateState>(newState);
        }

        [Fact]
        public void SwitchStateToExecuteAndSprintCanBeStarted()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CreateState(context, sprint);

            var newState = state.Execute();

            Assert.IsType<ExecuteState>(newState);
        }

        [Fact]
        public void SwitchStateToExecuteAndSprintCanNotBeStarted()
        {
            var startTime = DateTime.Today.AddDays(-4);
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", startTime, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CreateState(context, sprint);

            var newState = state.Execute();

            Assert.IsType<CreateState>(newState);
        }

        [Fact]
        public void SwitchStateToFinish()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CreateState(context, sprint);

            var newState = state.Finish();

            Assert.IsType<CreateState>(newState);
        }

        [Fact]
        public void SwitchStateToClose()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CreateState(context, sprint);

            var newState = state.Close();

            Assert.IsType<CreateState>(newState);
        }

        [Fact]
        public void SwitchStateToCancel()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CreateState(context, sprint);

            var newState = state.Cancel();

            Assert.IsType<CreateState>(newState);
        }
    }
}
