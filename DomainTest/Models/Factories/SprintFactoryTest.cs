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
            Sprint sprint = new Sprint("foobar", now, now, leadDeveloper, scrumMaster);

            SprintConcreteFactory factory = new SprintConcreteFactory();

            var cloneSprint = factory.Create(sprint);

            Assert.NotEqual(sprint, cloneSprint);
            Assert.Equal(sprint.StartTime, now);
            Assert.Equal(sprint.EndDate, now);
        }

        [Fact]
        public void CreateSprintCustom()
        {
            DateTime now = DateTime.Now;
            Member leadDeveloper = new Member("foobar", "foo@bar.com");
            Member scrumMaster = new Member("foobar", "foo@bar.com");

            SprintConcreteFactory factory = new SprintConcreteFactory();

            var sprint = factory.Create("foobar", now, now, leadDeveloper, scrumMaster);

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

            var sprint  = factory.Create("foobar", now, now, leadDeveloper, scrumMaster, doc);

            Assert.Equal(doc, sprint.Document);
            Assert.IsType<Sprint>(sprint);

        }
    }
}