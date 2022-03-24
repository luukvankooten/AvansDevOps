using System;

namespace Domain.Models.Factories
{
    public interface ISprintFactory
    {
        Sprint CreateRelease(string name, DateTime startDate, DateTime endDate, Member scrumMaster);
        Sprints.Sprint CreateReview(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, Document document = null);
    }
}