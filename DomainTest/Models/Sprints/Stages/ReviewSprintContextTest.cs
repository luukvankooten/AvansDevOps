using System;
using Domain.Models;
using Domain.Models.Notifications;
using Domain.Models.Sprints;
using Domain.Models.Sprints.Close;
using Xunit;

namespace DomainTest.Models.Sprints.Stages
{
    public class ReviewSprintContextTest
    {
        [Fact]
        public void CloseBehaviorShouldBeReview()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var notifier = new Notifier(sprint);
            var context = new ReviewSprintContext(sprint, notifier);

            Assert.IsType<ReviewBehavior>(context.CloseBehavior);
        }
}
}
