using System;
using Domain.Models.Notifications;
using Domain.Models.Sprints.Close;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class SprintConcreteFactory : ISprintFactory
    {
        public virtual Sprint Create(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, ICloseBehavior behavior)
        {
            return new Sprint(name, startTime, endDate, leadDeveloper, scrumMaster, behavior);
        }

        public virtual Sprint Create(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, ICloseBehavior behavior, Document document)
        {
            return new Sprint(name, startTime, endDate, leadDeveloper, scrumMaster, behavior, document);
        }
    }
}