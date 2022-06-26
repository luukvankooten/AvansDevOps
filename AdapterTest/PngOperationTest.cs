using System;
using System.IO;
using Adapter;
using Domain.Models;
using Domain.Models.Rapportage;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace AdapterTest
{
    public class PngOperationTest
    {
        [Fact]
        void ShouldExportToJpeg()
        {
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var export = new PngOperation();
            var report = new Report(sprint, export);

            report.Export();
            
            Assert.True(export.IsExported);
        }
    }
}