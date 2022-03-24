using Domain.Models;
using System;
using Moq;
using Xunit;
using Sprint = Domain.Models.Sprints.Sprint;
using Domain.Models.Rapportage;

namespace DomainTest.Models.Rapportage
{
    public class RapportageAddHeaderTest
    {
        [Fact]
        public void AddHeaderPdf()
        {
            Member leadDev = new Member("Foo", "bar");
            Member scrumMaster = new Member("Foo", "bar");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, leadDev, scrumMaster);

            Mock<RapportagePdf> rapportage = new Mock<RapportagePdf>();
            rapportage.Setup(x => x.AddHeader("foobar")).Returns(true);

            Assert.True(rapportage.Object.AddHeader("foobar"));
        }

        [Fact]
        public void AddHeaderPng()
        {
            Member leadDev = new Member("Foo", "bar");
            Member scrumMaster = new Member("Foo", "bar");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, leadDev, scrumMaster);

            Mock<RapportagePng> rapportage = new Mock<RapportagePng>();
            rapportage.Setup(x => x.AddHeader("foobar")).Returns(true);

            Assert.True(rapportage.Object.AddHeader("foobar"));
        }

        [Fact]
        public void AddHeaderJpeg()
        {
            Member leadDev = new Member("Foo", "bar");
            Member scrumMaster = new Member("Foo", "bar");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, leadDev, scrumMaster);

            Mock<RapportageJpeg> rapportage = new Mock<RapportageJpeg>();
            rapportage.Setup(x => x.AddHeader("foobar")).Returns(true);

            Assert.True(rapportage.Object.AddHeader("foobar"));
        }
    }
}