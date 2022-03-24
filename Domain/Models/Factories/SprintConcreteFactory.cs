using System;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class SprintConcreteFactory : ISprintFactory
    {
        public virtual Sprint CreateRelease(string name, DateTime startDate, DateTime endDate, Member scrumMaster)
        {
            return new Sprint(name, startDate, endDate, scrumMaster);
        }

        public virtual Sprints.Sprint CreateReview(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster)
        {
            return new Sprints.Sprint(name, startTime, endDate, leadDeveloper, scrumMaster, null);
        }

        public virtual Sprints.Sprint CreateReview(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, Document document)
        {
            return new Sprints.Sprint(name, startTime, endDate, leadDeveloper, scrumMaster, document);
        }
    }
}