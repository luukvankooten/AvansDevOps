using System;
namespace Domain.Models.Sprint.Actions
{
    public interface IAction
    {
        void Dispatch(Sprint sprint);
    }
}
