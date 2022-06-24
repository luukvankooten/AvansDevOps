using Domain.Models;
using Domain.Models.Factories;
using Domain.Models.Sprints.Close;
using Moq;
using System;
using Xunit;

namespace DomainTest.Models.Factories
{
    public class ItemFactoryTest
    {
        [Fact]
        public void CreateItem()
        {
            Member member = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Sprint sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);

            Item item = new Item(member, "foobar", sprint);

            Mock<ItemConcreteFactory> factoryMock = new Mock<ItemConcreteFactory>();
            factoryMock.Setup(x => x.Create(member, "foobar", sprint)).Returns(item);

            Assert.Equal(item, factoryMock.Object.Create(member, "foobar", sprint));
        }
    }
}