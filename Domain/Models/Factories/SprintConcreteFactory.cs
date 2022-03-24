using System;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class SprintConcreteFactory : ISprintFactory
    {
        public Sprint CreateRelease(string name, DateTime startDate, DateTime endDate, Member scrumMaster)
        {
            return new Sprint(name, startDate, endDate, scrumMaster);
        }

        public Sprints.Sprint CreateReview(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, Document document = null)
        {
            return new Sprints.Sprint(name, startTime, endDate, leadDeveloper, scrumMaster, document);
        }
    }
}