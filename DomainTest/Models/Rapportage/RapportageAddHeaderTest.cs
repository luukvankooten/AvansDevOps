using Domain.Models;
using System;
using Moq;
using Xunit;
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

            Mock<RapportagePdf> rapportageMock = new Mock<RapportagePdf>();
            rapportageMock.Setup(x => x.AddHeader("foobar")).Returns(true);

            Assert.True(rapportageMock.Object.AddHeader("foobar"));
        }

        [Fact]
        public void AddHeaderPng()
        {
            Member leadDev = new Member("Foo", "bar");
            Member scrumMaster = new Member("Foo", "bar");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, leadDev, scrumMaster);

            Mock<RapportagePng> rapportageMock = new Mock<RapportagePng>();
            rapportageMock.Setup(x => x.AddHeader("foobar")).Returns(true);

            Assert.True(rapportageMock.Object.AddHeader("foobar"));
        }

        [Fact]
        public void AddHeaderJpeg()
        {
            Member leadDev = new Member("Foo", "bar");
            Member scrumMaster = new Member("Foo", "bar");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, leadDev, scrumMaster);

            Mock<RapportageJpeg> rapportageMock = new Mock<RapportageJpeg>();
            rapportageMock.Setup(x => x.AddHeader("foobar")).Returns(true);

            Assert.True(rapportageMock.Object.AddHeader("foobar"));
        }
    }
}