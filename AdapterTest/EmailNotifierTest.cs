using System;
using System.IO;
using Adapter;
using Domain.Models;
using Domain.Models.Sprints.Close;
using Moq;
using Xunit;

namespace AdapterTest
{
    public class EmailNotifierTest
    {
        [Fact]
        public void EmailAdapterShouldSendMessageOnSprintUpdate()
        {
            var service = new EmailService();
            var adapater = new EmailAdapter(service);
            var email = new EmailNotifier(adapater);
            
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var context = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            
            Member[] members = {member};
            email.Update(context, members, "Update");
            Assert.Equal($"to: {member.Email} message: Update", service.builder.ToString());
        }
        
        [Fact]
        public void EmailAdapterShouldSendMessageOnItemUpdate()
        {
            var service = new EmailService();
            var adapater = new EmailAdapter(service);
            var email = new EmailNotifier(adapater);
            
            var member = new Member("foobar", "foobaz");
            var project = new Project(member);
            var sprint = new Sprint("bas", DateTime.Now, DateTime.Now, member, member, project, new Mock<ICloseBehavior>().Object);
            var context = new Item(member, member, "bar", sprint);

            Member[] members = {member};
            email.Update(context, members, "Update");
            Assert.Equal($"to: {member.Email} message: Update", service.builder.ToString());
        }
    }
}