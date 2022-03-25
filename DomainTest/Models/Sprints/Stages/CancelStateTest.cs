﻿using System;
using Domain.Models;
using Domain.Models.Notifications;
using Domain.Models.Sprints;
using Domain.Models.Sprints.Stages;
using Xunit;

namespace DomainTest.Models.Sprints.Stages
{
    public class CancelStateTest
    {
        [Fact]
        public void SwitchStateToCreate()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CancelState(context);

            var newState = state.Create();

            Assert.IsType<CancelState>(newState);
        }

        [Fact]
        public void SwitchStateToExecute()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CancelState(context);

            var newState = state.Execute();

            Assert.IsType<CancelState>(newState);
        }

        [Fact]
        public void SwitchStateToFinish()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CancelState(context);

            var newState = state.Finish();

            Assert.IsType<CancelState>(newState);
        }

        [Fact]
        public void SwitchStateToClose()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CancelState(context);

            var newState = state.Close();

            Assert.IsType<CancelState>(newState);
        }

        [Fact]
        public void SwitchStateToCancel()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);
            var state = new CancelState(context);

            var newState = state.Cancel();

            Assert.IsType<CancelState>(newState);
        }
    }
}