using System;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class SprintConcreteFactory : ISprintFactory
    {
        public virtual Sprint Create(Sprint sprint)
        {
            return new Sprint(sprint);
        }

        public virtual Sprint Create(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster)
        {
            return new Sprint(name, startTime, endDate, leadDeveloper, scrumMaster);
        }

        public virtual Sprint Create(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, Document document)
        {
            return new Sprint(name, startTime, endDate, leadDeveloper, scrumMaster, document);
        }
    }
}