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
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, scrumMaster, project, new Mock<ICloseBehavior>().Object);
            var item = new Item(member, member, "Bar", sprint);

            Mock<ItemConcreteFactory> factoryMock = new Mock<ItemConcreteFactory>();
            factoryMock.Setup(x => x.Create(member, member, "foobar", sprint)).Returns(item);

            Assert.Equal(item, factoryMock.Object.Create(member, member,"foobar", sprint));
        }
    }
}