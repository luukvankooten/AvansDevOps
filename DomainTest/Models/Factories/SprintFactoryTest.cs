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
        public void CreateProjectRelease()
        {
            DateTime now = DateTime.Now;
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Member productOwner = new Member("foobar", "foo@bar.com");
            Sprint sprint = new Sprint("foobar", now, now, scrumMaster);

            Mock<SprintConcreteFactory> factoryMock = new Mock<SprintConcreteFactory>();           

            factoryMock.Setup(x => x.CreateRelease("foobar", now, now, scrumMaster)).Returns(sprint);

            Assert.Equal(sprint, factoryMock.Object.CreateRelease("foobar", now, now, scrumMaster));
        }

        [Fact]
        public void CreateProjectReviewNoDocument()
        {
            DateTime now = DateTime.Now;
            Member leadDeveloper = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Member productOwner = new Member("foobar", "foo@bar.com");
            Domain.Models.Sprints.Sprint sprint = new Domain.Models.Sprints.Sprint("foobar", now, now, leadDeveloper, scrumMaster);

            Mock<SprintConcreteFactory> factoryMock = new Mock<SprintConcreteFactory>();
            factoryMock.Setup(x => x.CreateReview("foobar", now, now, leadDeveloper, scrumMaster)).Returns(sprint);

            Assert.Equal(sprint, factoryMock.Object.CreateReview("foobar", now, now, leadDeveloper, scrumMaster));
        }

        [Fact]
        public void CreateProjectReviewWithDocument()
        {
            DateTime now = DateTime.Now;
            Member leadDeveloper = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Member productOwner = new Member("foobar", "foo@bar.com");
            Document doc = new Document();
            Domain.Models.Sprints.Sprint sprint = new Domain.Models.Sprints.Sprint("foobar", now, now, leadDeveloper, scrumMaster, doc);

            Mock<SprintConcreteFactory> factoryMock = new Mock<SprintConcreteFactory>();
            factoryMock.Setup(x => x.CreateReview("foobar", now, now, leadDeveloper, scrumMaster, doc)).Returns(sprint);

            Assert.Equal(sprint, factoryMock.Object.CreateReview("foobar", now, now, leadDeveloper, scrumMaster, doc));
        }
    }
}