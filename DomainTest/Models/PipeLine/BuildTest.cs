using System;
using Domain.Models;
using Domain.Models.Notifications;
using Domain.Models.Pipeline;
using Domain.Models.Sprints.Close;
using Moq;
using Moq.Protected;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class BuildTest
    {

        [Fact]
        public void BuildTestShouldOutput()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            
            var phase = new Mock<Build>(context);

            phase.Protected().Setup("HookStart");

            phase.Object.Execute();
            
            phase.Protected().Verify("HookStart", Times.Exactly(1));
        }


        [Fact]
        public void ShouldRaiseErrorOnFailAnd()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);

            var mock = new Mock<ISprintObserver>();
            
            context.AddObserver(mock.Object);
            
            Member[] members = { member, member  };

            var phase = new Build(context);

            phase.Failed = true;
            
            Assert.Throws<Exception>(() => phase.Execute());

            mock.Verify(x => x.Update(context, members, "The build has failed"), Times.Exactly(1));
        }
        
    }
}
