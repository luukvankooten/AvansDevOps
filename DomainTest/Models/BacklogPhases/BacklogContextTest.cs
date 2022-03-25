using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Domain.Models.Notifications;
using Xunit;

namespace DomainTest.Models.BacklogPhases
{
    public class BacklogContextTest
    {
        [Fact]
        public void BacklogPhashesSuccesItem()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);

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
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);

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
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var item = new Item(member, "bar", sprint);
            var notifier = new Notifier(sprint);
            var context = new BacklogContext(item, notifier);

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
            //Assert op throw Invalid
        }

        [Fact]
        public void BackLogDiscussionIsOpen()
        {

        }

        [Fact]
        public void BackLogDiscussionReOpen()
        {
            //1. thread open discussies toegevoed
            //2. kaart in Done discussie gesloten
            //3. kaart terug naar todo
            //4. Thread discusie item toevoegen
        }

    }
}
