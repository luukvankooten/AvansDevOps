using System;
using Domain.Models;
using Domain.Models.Discussions;
using Xunit;

namespace DomainTest.Models.Discussions
{
    public class ReactionTest
    {

        [Fact]
        public void ReactionShouldBeLeaf()
        {
            var member = new Member("Foo", "Baz");
            var reaction = new Reaction("Foo", "Bar", member);

            Assert.False(reaction.IsComposite());
        }
    }
}
