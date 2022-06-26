using System;
using Domain.Models.Pipeline;
using Domain.Models;
using Moq;
using Xunit;
using Domain.Models.Sprints.Close;
using Moq.Protected;

namespace DomainTest.Models.PipeLine
{
    public class DeployTest
    {
        [Fact]
        public void DeployTestShouldOutput()
        {
            var phase = new Mock<Deploy>();

            phase.Protected().Setup("HookStart");

            phase.Object.Execute();
            
            phase.Protected().Verify("HookStart", Times.Exactly(1));
        }

    }
}
