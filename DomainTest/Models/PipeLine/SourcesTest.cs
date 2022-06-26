using Domain.Models.Pipeline;
using Moq;
using Moq.Protected;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class SourcesTest
    {

        [Fact]
        public void SourceTestShouldOutput()
        {
            var phase = new Mock<Sources>();

            phase.Protected().Setup("HookStart");

            phase.Object.Execute();
            
            phase.Protected().Verify("HookStart", Times.Exactly(1));
        }
    }
}
