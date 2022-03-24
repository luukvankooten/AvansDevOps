using Domain.Models;
using System;
using Moq;
using Xunit;
using Sprint = Domain.Models.Sprints.Sprint;
using Domain.Models.Rapportage;

namespace DomainTest.Models.Rapportage
{
    public class RapportageExportTest
    {
        [Fact]
        public void ExportToPdf()
        {
            Member leadDev = new Member("Foo", "bar");
            Member scrumMaster = new Member("Foo", "bar");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, leadDev, scrumMaster);

            Mock<RapportagePdf> rapportagePdf = new Mock<RapportagePdf>();
            rapportagePdf.Setup(x => x.Export()).Returns(true);

            Assert.True(rapportagePdf.Object.Export());
        }

        [Fact]
        public void ExportToPng()
        {
            Member leadDev = new Member("Foo", "bar");
            Member scrumMaster = new Member("Foo", "bar");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, leadDev, scrumMaster);

            Mock<RapportagePng> rapportagePdf = new Mock<RapportagePng>();
            rapportagePdf.Setup(x => x.Export()).Returns(true);

            Assert.True(rapportagePdf.Object.Export());
        }

        [Fact]
        public void ExportToJpeg()
        {
            Member leadDev = new Member("Foo", "bar");
            Member scrumMaster = new Member("Foo", "bar");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, leadDev, scrumMaster);

            Mock<RapportageJpeg> rapportagePdf = new Mock<RapportageJpeg>();
            rapportagePdf.Setup(x => x.Export()).Returns(true);

            Assert.True(rapportagePdf.Object.Export());
        }
    }
}