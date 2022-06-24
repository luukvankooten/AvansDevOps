using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Domain.Models.Discussions;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace DomainTest.Models
{
    public class ItemTest
    {
        [Fact]
        public void BacklogPhashesSuccesItem()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);

            context.Doing();

            Assert.IsType<DoingState>(context.State);

            context.ReadyForTesting();

            Assert.IsType<ReadyForTestingState>(context.State);

            context.Testing();

            Assert.IsType<TestingState>(context.State);

            context.Tested();

            Assert.IsType<TestedState>(context.State);

            context.Done();

            Assert.IsType<DoneState>(context.State);
        }


        [Fact]
        public void BacklogPhasesTesterRejectsItem()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);

            context.Doing();

            Assert.IsType<DoingState>(context.State);

            context.ReadyForTesting();

            Assert.IsType<ReadyForTestingState>(context.State);

            context.Testing();

            Assert.IsType<TestingState>(context.State);

            context.Todo();

            Assert.IsType<TodoState>(context.State);
        }

        [Fact]
        public void BacklogPhasesLeadDeveloperRejectsItemByDOD()
        {
            var member = new Member("Foo", "foo");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);

            context.Doing();

            Assert.IsType<DoingState>(context.State);

            context.ReadyForTesting();

            Assert.IsType<ReadyForTestingState>(context.State);

            context.Testing();

            Assert.IsType<TestingState>(context.State);

            context.Tested();

            Assert.IsType<TestedState>(context.State);

            context.ReadyForTesting();

            Assert.IsType<ReadyForTestingState>(context.State);
        }

        [Fact]
        public void BackLogIsDoneDiscussionClose()
        {
            var member = new Member("Foo", "foo");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var discussion = new Discussion("Foo", "bar", member);


            context.Doing();
            // Na doing, discussie geopend

            context.ReadyForTesting();
            context.Testing();
            context.Tested();
            context.Done();
            // Na done, discussie gesloten

            Assert.Throws(new InvalidOperationException().GetType(), () => context.ThreadDiscussion.AddDiscussion(discussion));
        }

        [Fact]
        public void BackLogDiscussionIsOpen()
        {
            var member = new Member("Foo", "foo");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var discussion = new Discussion("Foo", "bar", member);

            context.Doing();
            // Na doing, discussie geopend

            Assert.Null(Record.Exception(() => context.ThreadDiscussion.AddDiscussion(discussion)));
        }

        [Fact]
        public void BackLogDiscussionReOpen()
        {
            var member = new Member("Foo", "foo");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var discussion = new Discussion("Foo", "bar", member);

            context.Doing();
            // Na doing, discussie geopend

            context.ReadyForTesting();
            context.Testing();
            context.Tested();
            context.Done();
            // Na done, discussie gesloten

            Assert.Throws(new InvalidOperationException().GetType(), () => context.ThreadDiscussion.AddDiscussion(discussion));

            context.Todo();
            // Na Todo, discussie weer geopend

            Assert.Null(Record.Exception(() => context.ThreadDiscussion.AddDiscussion(discussion)));
        }


        [Fact]
        public void AddSubItemWhenStateIsNotCreated()
        {
            var member = new Member("Foo", "foo");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            sprint.Execute();
            // context.Doing();
            // Na done

            Assert.Throws(new InvalidOperationException().GetType(), () => context.AddSubItem(member, "Hello"));
        }
    }
}

