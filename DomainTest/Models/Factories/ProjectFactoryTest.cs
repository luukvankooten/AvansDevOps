using Domain.Models;
using Domain.Models.Factories;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DomainTest.Models.Factories
{
    public class ProjectFactoryTest
    {
        [Fact]
        public void CreateProject()
        {
            Member scrumMaster = new Member("foobar", "foo@bar.com");
            Member productOwner = new Member("foobar", "foo@bar.com");
            Sprint sprint = new Sprint("foobar", DateTime.Now, DateTime.Now, scrumMaster);
            List<Sprint> list = new List<Sprint>() { sprint };

            Project project = new Project(list, productOwner);

            Mock<ProjectConcreteFactory> factoryMock = new Mock<ProjectConcreteFactory>();
            factoryMock.Setup(x => x.Create(list, productOwner)).Returns(project);

            Assert.Equal(project, factoryMock.Object.Create(list, productOwner));
        }
    }
}