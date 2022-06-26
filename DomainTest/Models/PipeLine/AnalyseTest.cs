using Domain.Models.Pipeline;
using Moq;
using Moq.Protected;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class AnalyseTest
    {

        [Fact]
        public void AnalyseTestShouldOutput()
        {
            var phase = new Mock<Analyse>();

            phase.Protected().Setup("HookStart");

            
            phase.Object.Execute();
            
            phase.Protected().Verify("HookStart", Times.Exactly(1));
        }
    }
}
