using System;
using Domain.Models;
using Xunit;

namespace DomainTest.Models
{
    public class SprintTest
    {
        public SprintTest()
        {
        }

        [Fact]
        public void CopyConstructorShouldCopyToNewInstance()
        {
            var member = new Member("Foo", "Baz");

            var sprint = new Sprint("foo", DateTime.Now, DateTime.Now, member, member);

            var copySprint = new Sprint(sprint);

            Assert.Equal(copySprint.Document, sprint.Document);
            Assert.Equal(copySprint.Name, sprint.Name);
            Assert.Equal(copySprint.StartTime, sprint.StartTime);
            Assert.Equal(copySprint.EndDate, sprint.EndDate);
        }
    }
}
