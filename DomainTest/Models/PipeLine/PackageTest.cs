using Domain.Models.Pipeline;
using Moq;
using Moq.Protected;
using Xunit;

namespace DomainTest.Models.PipeLine
{
    public class PackageTest
    {
        [Fact]
        public void PackageTestShouldOutput()
        {
            var phase = new Mock<Package>();

            phase.Protected().Setup("HookStart");

            phase.Object.Execute();
            
            phase.Protected().Verify("HookStart", Times.Exactly(1));
        }
    }
}
