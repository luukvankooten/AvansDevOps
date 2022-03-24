using Domain.Models;
using Domain.Models.Factories;
using Moq;
using System;
using Xunit;

namespace DomainTest.Models.Factories
{
    public class MemberFactoryTest
    {
        [Fact]
        public void CreateMember()
        {
            Member member = new Member("foobar", "foo@bar.com");

            Mock<MemberConcreteFactory> factoryMock = new Mock<MemberConcreteFactory>();
            factoryMock.Setup(x => x.Create("foobar", "foo@bar.com")).Returns(member);

            Assert.Equal(member, factoryMock.Object.Create("foobar", "foo@bar.com"));
        }
    }
}