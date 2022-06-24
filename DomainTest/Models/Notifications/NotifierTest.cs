using System;
using Domain.Models;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace DomainTest.Models.Notifications
{
    public class NotifierTest
    {


        [Fact]
        public void NotifierShouldCallObserverMethodCall()
        {
            var observer1 = new Mock<ISprintObserver>();
            var observer2 = new Mock<ISprintObserver>();

            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            
            sprint.AddObserver(observer1.Object);
            sprint.AddObserver(observer2.Object);

            sprint.Notify();

            sprint.DetachObserver(observer2.Object);

            sprint.Notify();

            observer1.Verify(x => x.Update(sprint), Times.Exactly(2));
            observer2.Verify(x => x.Update(sprint), Times.Exactly(1));
        }
    }
}
