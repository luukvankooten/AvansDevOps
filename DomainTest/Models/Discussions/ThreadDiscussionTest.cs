using System;
using Domain.Models;
using Domain.Models.Discussions;
using Xunit;

namespace DomainTest.Models.Discussions
{
    public class ThreadDiscussionTest
    {
        [Fact]
        public void DiscussionIsOpen()
        {
            var member = new Member("Foo", "Baz");
            var sprint = new Sprint("Foo", DateTime.Now, DateTime.Now, member, member);
            var item = new Item(member, "Bar", sprint);
            var thread = new ThreadDiscussion(item);

            var discussion = new Discussion("foo", "baz", member);

            thread.AddDiscussion(discussion);

            Assert.True(thread.HasDiscussion(discussion));
        }

        [Fact]
        public void DiscussionIsClosed()
        {
            var member = new Member("Foo", "Baz");
            var sprint = new Sprint("Foo", DateTime.Now, DateTime.Now, member, member);
            var item = new Item(member, "Bar", sprint);
            var thread = new ThreadDiscussion(item);

            var discussion = new Discussion("foo", "baz", member);

            thread.IsClosed = true;

            Assert.Throws<InvalidOperationException>(() => thread.AddDiscussion(discussion));
            Assert.False(thread.HasDiscussion(discussion));
        }
    }
}
