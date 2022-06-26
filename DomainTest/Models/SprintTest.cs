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
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);

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
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);

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
        public void AddExistingItemWhichHasAsSubItem()
        {
            var member = new Member("Foo", "foo");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, member,"bar", sprint);

            var item = context.AddSubItem(member, "hello world");

            Assert.Throws(new InvalidOperationException().GetType(), () => sprint.AddItem(item));
        }
        
        
        [Fact]
        public void ItemIsAlreadyInBacklog()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            
            var item = new Item(member, member,"foo", context);

            context.Execute();

            Assert.Throws(new InvalidOperationException().GetType(), () => context.AddItem(item));
        }

        [Fact]
        public void SprintIsNotRightStateToAddItem()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            
            context.Execute();

            Assert.Throws(new InvalidOperationException().GetType(), () => context.AddItem(new Item(member, member,"foo", context)));
        }
        
        [Fact]
        public void SprintIsCreatedAddItems()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);

            var exception = Record.Exception(() => new Item(member, member,"foo", context));

            Assert.Null(exception);
        }
        
        [Fact]
        public void CanEditName()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            
            var exception = Record.Exception(() => context.Name = "bas");

            Assert.Null(exception);
        }

        [Fact]
        public void CanEditScrumMaster()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            var exception = Record.Exception(() => context.ScrumMaster = newMember);

            Assert.Null(exception);
        }
        
        [Fact]
        public void CanEditScrumLead()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            var exception = Record.Exception(() => context.ScrumMaster = newMember);

            Assert.Null(exception);
        }
        
        [Fact]
        public void CanEditScrumEndTime()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            var exception = Record.Exception(() => context.EndDate = DateTime.Now);

            Assert.Null(exception);
        }
        
        [Fact]
        public void CanEditScrumStartTime()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            var exception = Record.Exception(() => context.StartTime = DateTime.Now);

            Assert.Null(exception);
        }
        
        [Fact]
        public void CantEditName()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            context.Execute();
            
            Assert.Throws(new InvalidOperationException().GetType(), () => context.Name = "bar");
        }

        [Fact]
        public void CantEditScrumMaster()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            context.Execute();
            
            Assert.Throws(new InvalidOperationException().GetType(), () => context.ScrumMaster = member);
        }
        
        [Fact]
        public void CantEditScrumLead()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            context.Execute();
            
            Assert.Throws(new InvalidOperationException().GetType(), () => context.LeadDeveloper = member);
        }
        
        [Fact]
        public void CantEditScrumEndTime()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            context.Execute();
            
            Assert.Throws(new InvalidOperationException().GetType(), () => context.EndDate = DateTime.Now);
        }
        
        [Fact]
        public void CantEditScrumStartTime()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var newMember = new Member("foobar", "foobaz");
            context.Execute();
            
            Assert.Throws(new InvalidOperationException().GetType(), () => context.StartTime = DateTime.Now);
        }
    }
}
