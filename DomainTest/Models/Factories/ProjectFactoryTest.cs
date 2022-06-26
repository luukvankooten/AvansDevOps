using Domain.Models;
using Domain.Models.Factories;
using Domain.Models.Sprints.Close;
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
            Member member = new Member("foobar", "foo@bar.com");
            Member productOwner = new Member("foobar", "foo@bar.com");
            
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, productOwner, project, new Mock<ICloseBehavior>().Object);
            var item = new Item(member, member, "Bar", sprint);

            Mock<ProjectConcreteFactory> factoryMock = new Mock<ProjectConcreteFactory>();
            factoryMock.Setup(x => x.Create(productOwner)).Returns(project);

            Assert.Equal(project, factoryMock.Object.Create(productOwner));
        }
    }
}