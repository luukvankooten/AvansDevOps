using System;
using Domain.Models.Sprints.Close;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public interface ISprintFactory
    {
        Sprint Create(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, ICloseBehavior behavior);
        Sprint Create(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, ICloseBehavior behavior, Document document);
    }
}