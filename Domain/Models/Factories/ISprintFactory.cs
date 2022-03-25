using System;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public interface ISprintFactory
    {
        Sprint Create(Sprint sprint);
        Sprint Create(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster);
        Sprint Create(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, Document document);
    }
}