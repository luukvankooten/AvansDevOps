using System;
namespace Domain.Models.Sprints.Close
{
    public interface ICloseBehavior
    {
        void Close(Sprint sprint);
    }
}
