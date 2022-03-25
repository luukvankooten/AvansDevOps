using System;
using Domain.Models;
using Domain.Models.Sprints.Close;
using Xunit;

namespace DomainTest.Models.Sprints.Close
{
    public class ReviewBehaviorTest
    {
        public ReviewBehaviorTest()
        {
        }

        [Fact]
        public void FileIsUploaded()
        {
            var member = new Member("foobar", "foobaz");
            var doc = new Document();
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, doc);
            var review = new ReviewBehavior();

            var exception = Record.Exception(() => review.Close(sprint));

            Assert.Null(exception);
        }


        [Fact]
        public void FileIsNotUploaded()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var review = new ReviewBehavior();

            Assert.Throws<InvalidProgramException>(() => review.Close(sprint));

        }
    }
}
