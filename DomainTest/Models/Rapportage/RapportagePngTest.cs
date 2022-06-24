using System;
using Domain.Models.Rapportage;
using Domain.Models;
using Xunit;
using Domain.Models.Sprints.Close;
using Moq;

namespace DomainTest.Models.Rapportage
{
    public class RapportagePngTest
    {
        [Fact]
        public void GenerateWithHeaderAndFooter()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var generator = new RapportagePng(sprint);

            var header = new Header("Baz");
            var footer = new Footer("Foo");

            Assert.True(generator.Generate(header, footer));
        }

        [Fact]
        public void GenerateWithHeader()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var generator = new RapportagePng(sprint);

            var header = new Header("Baz");

            Assert.True(generator.Generate(header));
        }

        [Fact]
        public void GenerateWithFooter()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, new Mock<ICloseBehavior>().Object);
            var generator = new RapportagePng(sprint);

            var footer = new Footer("Foo");

            Assert.True(generator.Generate(footer));
        }

    }
}
