using System;
using Domain.Models;
using Domain.Models.Notifications;
using Moq;
using Xunit;

namespace DomainTest.Models.Notifications
{
    public class NotifierTest
    {


        [Fact]
        public void NotifierShouldCallObserverMethodCall()
        {
            var observer1 = new Mock<IObserver>();
            var observer2 = new Mock<IObserver>();

            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);

            var notifier = new Notifier(sprint);

            notifier.AddObserver(observer1.Object);
            notifier.AddObserver(observer2.Object);

            notifier.Notify();

            notifier.DetachObserver(observer2.Object);

            notifier.Notify();

            observer1.Verify(x => x.Update(sprint), Times.Exactly(2));
            observer2.Verify(x => x.Update(sprint), Times.Exactly(1));
        }
    }
}
