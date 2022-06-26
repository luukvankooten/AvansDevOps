using System;
using Domain.Models;
using Domain.Models.Rapportage;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace DomainTest.Models.Rapportage
{
    public class ReportTest
    {
        [Fact]
        public void ReportShouldCallExport()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var mock = new Mock<IReportExportStrategy>();
            var report = new Report(sprint, mock.Object);

            report.Export();
            
            mock.Verify(x => x.Export(report), Times.Exactly(1));
        }

        [Fact]
        public void ReportShouldAddHeader()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var mock = new Mock<IReportExportStrategy>();
            var report = new Report(sprint, mock.Object);

            var header = new Header("foo");
            
            report.AddHeader(header);
            Assert.True(report.Headers.Contains(header));
        }

        [Fact]
        public void ReportShouldAddFooter()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var mock = new Mock<IReportExportStrategy>();
            var report = new Report(sprint, mock.Object);

            var footer = new Footer("foo");
            
            report.AddFooter(footer);
            Assert.True(report.Footers.Contains(footer));
        }
    }
}