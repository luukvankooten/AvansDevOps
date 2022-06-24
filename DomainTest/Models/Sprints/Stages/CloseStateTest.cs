using System;
using Domain.Models.Sprints.Stages;
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
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var state = new CloseState(context);

            var newState = state.Create();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void SwitchStateToExecute()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var state = new CloseState(context);

            var newState = state.Execute();

            Assert.IsType<CloseState>(newState);
        }


        [Fact]
        public void SwitchStateToFinish()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var state = new CloseState(context);

            var newState = state.Finish();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void SwitchStateToClose()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object, new Document());
            var state = new CloseState(context);

            var newState = state.Close();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void SwitchStateToCancel()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var state = new CloseState(context);

            var newState = state.Cancel();

            Assert.IsType<CloseState>(newState);
        }

        [Fact]
        public void CloseBehaviorCallTest()
        {
            var member = new Member("foobar", "foobaz");
            var mock = new Mock<ICloseBehavior>();
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, mock.Object);

            var state = new CloseState(context);

            state.Close();

            mock.Verify(x => x.Close(context), Times.Exactly(1));
        }

    }
}
