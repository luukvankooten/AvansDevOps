using System;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Stages;
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
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var state = new FinishState(context);

            var newState = state.Create();

            Assert.IsType<FinishState>(newState);
        }

        [Fact]
        public void SwitchStateToExecute()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var state = new FinishState(context);

            var newState = state.Execute();

            Assert.IsType<FinishState>(newState);
        }


        [Fact]
        public void SwitchStateToFinish()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var state = new FinishState(context);

            var newState = state.Finish();

            Assert.IsType<FinishState>(newState);
        }

        [Fact]
        public void SwitchStateToClose()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var state = new FinishState(context);

            var newState = state.Close();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void SwitchStateToCancel()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var state = new FinishState(context);

            var newState = state.Cancel();

            Assert.IsType<CancelState>(newState);
        }

        [Fact]
        public void SwitchStateToCancelShouldRecieveNotification()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);

            var observer = new Mock<ISprintObserver>();

            context.AddObserver(observer.Object);

            var state = new FinishState(context);

            state.Cancel();
            Member[] members = {member};
            observer.Verify(x => x.Update(context, members, "The sprint has been canceled"), Times.Exactly(1));
        }

    }
}
