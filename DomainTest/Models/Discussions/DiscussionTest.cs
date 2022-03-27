using System;
using Domain.Models;
using Domain.Models.Discussions;
using Xunit;

namespace DomainTest.Models.Discussions
{
    public class DiscussionTest
    {
        [Fact]
        public void AddReactionToDiscussion()
        {
            var member = new Member("Foo", "Email");
            var discussion = new Discussion("bar", "bar", member);
            var reaction = new Reaction("baz", "baz", member);

            discussion.Add(reaction);
            var itterator = discussion.GetCompositions();
            itterator.MoveNext();

            Assert.Equal(reaction, itterator.Current);
        }

        [Fact]
        public void AddCompositeElementToDiscussionShouldTrhowError()
        {
            var member = new Member("Foo", "Email");
            var discussion = new Discussion("bar", "bar", member);
            var discussion1 = new Discussion("baz", "baz", member);

            Assert.Throws<InvalidOperationException>(() => discussion.Add(discussion1));
        }
    }
}
