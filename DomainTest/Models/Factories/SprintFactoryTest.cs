using Domain.Models;
using Domain.Models.Factories;
using Moq;
using System;
using Xunit;

namespace DomainTest.Models.Factories
{
    public class SprintFactoryTest
    {
        [Fact]
        public void CreateSprintExisting()
        {
            DateTime now = DateTime.Now;
            Member leadDeveloper = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Member productOwner = new Member("foobar", "foo@bar.com");
            Sprint sprint = new Sprint("foobar", now, now, leadDeveloper, scrumMaster);

            Mock<SprintConcreteFactory> factoryMock = new Mock<SprintConcreteFactory>();

            factoryMock.Setup(x => x.Create(sprint)).Returns(sprint);

            Assert.Equal(sprint, factoryMock.Object.Create(sprint));
        }

        [Fact]
        public void CreateSprintCustom()
        {
            DateTime now = DateTime.Now;
            Member leadDeveloper = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Member productOwner = new Member("foobar", "foo@bar.com");
            Sprint sprint = new Sprint("foobar", now, now, leadDeveloper, scrumMaster);

            Mock<SprintConcreteFactory> factoryMock = new Mock<SprintConcreteFactory>();
            factoryMock.Setup(x => x.Create("foobar", now, now, leadDeveloper, scrumMaster)).Returns(sprint);

            Assert.Equal(sprint, factoryMock.Object.Create("foobar", now, now, leadDeveloper, scrumMaster));
        }

        [Fact]
        public void CreateSprintCustomWithDocument()
        {
            DateTime now = DateTime.Now;
            Member leadDeveloper = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Member productOwner = new Member("foobar", "foo@bar.com");
            Document doc = new Document();
            Sprint sprint = new Sprint("foobar", now, now, leadDeveloper, scrumMaster, doc);

            Mock<SprintConcreteFactory> factoryMock = new Mock<SprintConcreteFactory>();
            factoryMock.Setup(x => x.Create("foobar", now, now, leadDeveloper, scrumMaster, doc)).Returns(sprint);

            Assert.Equal(sprint, factoryMock.Object.Create("foobar", now, now, leadDeveloper, scrumMaster, doc));
        }
    }
}