using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.Models.Pipeline;
using Domain.Models.Sprints.Close;
using Moq;
using Moq.Protected;
using Xunit;

namespace DomainTest.Models.Sprints.Close
{
    public class PipeLineBehaviorTest
    {
        

        [Fact]
        public void PipeLineCloseShouldCallPipelineExecute()
        {
            var mock = new Mock<PipelinePhase>();


            mock.Protected().Setup("Run");

            var list = new List<PipelinePhase>();
            
            list.Add(mock.Object);

            var close = new PipeLineBehavior(list); 
            
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            
            close.Close(sprint);

            mock.Protected().Verify("Run", Times.Exactly(1));
        }
        
    }
}
