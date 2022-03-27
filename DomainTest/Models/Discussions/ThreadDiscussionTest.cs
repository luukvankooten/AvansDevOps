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

        [Fact]
        public void AddMultipleDiscussionToThreads()
        {
            var member = new Member("Foo", "Baz");
            var sprint = new Sprint("Foo", DateTime.Now, DateTime.Now, member, member);
            var item = new Item(member, "Bar", sprint);
            var thread = new ThreadDiscussion(item);
            var discussion1 = new Discussion("foo", "baz", member);
            var discussion2 = new Discussion("bar", "baz", member);

            thread.AddDiscussion(discussion1);
            thread.AddDiscussion(discussion2);

            var itterator = thread.GetDiscussions();

            itterator.MoveNext();

            Assert.Equal(discussion1, itterator.Current);

            itterator.MoveNext();

            Assert.Equal(discussion2, itterator.Current);
        }
    }
}
