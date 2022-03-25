using System;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public interface ISprintFactory
    {
        Sprint CreateReview(string name, DateTime startTime, DateTime endDate, Member leadDeveloper, Member scrumMaster, Document document = null);
    }
}