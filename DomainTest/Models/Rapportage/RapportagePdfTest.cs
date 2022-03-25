using System;
using Domain.Models;
using Domain.Models.Rapportage;
using Xunit;

namespace DomainTest.Models.Rapportage
{
    public class RapportagePdfTest
    {
        [Fact]
        public void GenerateWithHeaderAndFooter()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var generator = new RapportagePdf(sprint);

            var header = new Header("Baz");
            var footer = new Footer("Foo");

            Assert.True(generator.Generate(header, footer));
        }

        [Fact]
        public void GenerateWithHeader()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var generator = new RapportagePdf(sprint);

            var header = new Header("Baz");

            Assert.True(generator.Generate(header));
        }

        [Fact]
        public void GenerateWithFooter()
        {
            var member = new Member("foobar", "foobaz");
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member);
            var generator = new RapportagePdf(sprint);

            var footer = new Footer("Foo");

            Assert.True(generator.Generate(footer));
        }
    }
}
