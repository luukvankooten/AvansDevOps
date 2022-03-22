using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Xunit;

namespace Domain.Test.Models.BacklogPhases
{
    public class TodoTest
    {
        [Fact]
        public void SwitchStateToTodo()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var context = new BacklogContext(item);
            var todoState = new TodoState(context);

            var newState = todoState.Todo();

            Assert.IsType<TodoState>(newState);
        }

        [Fact]
        public void SwitchStateToDoing()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var context = new BacklogContext(item);
            var todoState = new TodoState(context);

            var newState = todoState.Doing();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateToReadyForTesting()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var context = new BacklogContext(item);
            var todoState = new TodoState(context);

            var newState = todoState.ReadyForTesting();

            Assert.IsType<TodoState>(newState);
        }

        [Fact]
        public void SwitchStateToTesting()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var context = new BacklogContext(item);
            var todoState = new TodoState(context);

            var newState = todoState.Testing();

            Assert.IsType<TodoState>(newState);
        }

        [Fact]
        public void SwitchStateTested()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var developer = new Member("Foo", "foo");
            var item = new Item(developer, "bar", sprint);
            var context = new BacklogContext(item);
            var todoState = new TodoState(context);

            var newState = todoState.Tested();

            Assert.IsType<TodoState>(newState);
        }

        [Fact]
        public void SwitchStateToDone()
        {
            var scrumMaster = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, scrumMaster);
            var member = new Member("Foo", "foo");
            var item = new Item(member, "bar", sprint);
            var context = new BacklogContext(item);
            var todoState = new TodoState(context);

            var newState = todoState.Done();

            Assert.IsType<TodoState>(newState);
        }
    }
}
