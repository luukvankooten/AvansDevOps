﻿using System;
using Domain.Models;
using Domain.Models.BacklogPhases;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace Domain.Test.Models.BacklogPhases
{
    public class TodoStateTest
    {
        [Fact]
        public void SwitchStateToTodo()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new TodoState(context);

            var newState = state.Todo();

            Assert.IsType<TodoState>(newState);
        }

        [Fact]
        public void SwitchStateToDoing()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new TodoState(context);

            var newState = state.Doing();

            Assert.IsType<DoingState>(newState);
        }

        [Fact]
        public void SwitchStateToReadyForTesting()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new TodoState(context);

            var newState = state.ReadyForTesting();

            Assert.IsType<TodoState>(newState);
        }

        [Fact]
        public void SwitchStateToTesting()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new TodoState(context);

            var newState = state.Testing();

            Assert.IsType<TodoState>(newState);
        }

        [Fact]
        public void SwitchStateTested()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new TodoState(context);

            var newState = state.Tested();

            Assert.IsType<TodoState>(newState);
        }

        [Fact]
        public void SwitchStateToDone()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, "bar", sprint);
            var state = new TodoState(context);

            var newState = state.Done();

            Assert.IsType<TodoState>(newState);
        }
    }
}
