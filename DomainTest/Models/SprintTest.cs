using System;
using Domain.Models;
using Domain.Models.Sprints.Close;
using Domain.Models.Sprints.Stages;
using Moq;
using Xunit;

namespace DomainTest.Models
{
    public class SprintTest
    {
        [Fact]
        public void SprintContextHappyStateTest()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);

            context.Create();

            Assert.IsType<CreateState>(context.SprintStage);

            context.Execute();

            Assert.IsType<ExecuteState>(context.SprintStage);

            context.Finish();

            Assert.IsType<FinishState>(context.SprintStage);

            context.Close();

            Assert.IsType<CloseState>(context.SprintStage);
        }

        [Fact]
        public void SprintContextCancelStateTest()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);

            context.Create();

            Assert.IsType<CreateState>(context.SprintStage);

            context.Execute();

            Assert.IsType<ExecuteState>(context.SprintStage);

            context.Finish();

            Assert.IsType<FinishState>(context.SprintStage);

            context.Cancel();

            Assert.IsType<CancelState>(context.SprintStage);
        }
        
        
        [Fact]
        public void ItemIsAlreadyInBacklog()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            
            var item = new Item(member, "foo", context);

            context.AddItem(item);
            
            context.Execute();

            Assert.Throws(new InvalidOperationException().GetType(), () => context.AddItem(item));
        }

        [Fact]
        public void SprintIsNotRightStateToAddItem()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            
            context.Execute();

            Assert.Throws(new InvalidOperationException().GetType(), () => context.AddItem(new Item(member, "foo", context)));
        }
        
        [Fact]
        public void SprintIsCreatedAddItems()
        {
            var member = new Member("foobar", "foobaz");
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);

            var exception = Record.Exception(() => context.AddItem(new Item(member, "foo", context)));

            Assert.Null(exception);
        }
    }
}
