﻿using Domain.Models.Pipeline;
using Moq;
using Moq.Protected;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class TestTest
    {
        [Fact]
        public void TestTestShouldOutput()
        {
            var phase = new Mock<Test>();

            phase.Protected().Setup("HookStart");

            phase.Object.Execute();
            
            phase.Protected().Verify("HookStart", Times.Exactly(1));
        }
    }
}
