using Domain.Models;
using Domain.Models.Factories;
using Domain.Models.Sprints.Close;
using Moq;
using System;
using Xunit;

namespace DomainTest.Models.Factories
{
    public class SprintFactoryTest
    {
        [Fact]
        public void CreateSprintCustom()
        {
            DateTime now = DateTime.Now;
            Member leadDeveloper = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");

            SprintConcreteFactory factory = new SprintConcreteFactory();

            var sprint = factory.Create("foobar", now, now, leadDeveloper, scrumMaster, new Mock<ICloseBehavior>().Object);

            Assert.Equal("foobar", sprint.Name);
            Assert.Equal(leadDeveloper, sprint.LeadDeveloper);
            Assert.IsType<Sprint>(sprint);
        }

        [Fact]
        public void CreateSprintCustomWithDocument()
        {
            DateTime now = DateTime.Now;
            Member leadDeveloper = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Document doc = new Document();

            SprintConcreteFactory factory = new SprintConcreteFactory();

            var sprint  = factory.Create("foobar", now, now, leadDeveloper, scrumMaster, new Mock<ICloseBehavior>().Object, doc);

            Assert.Equal(doc, sprint.Document);
            Assert.IsType<Sprint>(sprint);

        }
    }
}