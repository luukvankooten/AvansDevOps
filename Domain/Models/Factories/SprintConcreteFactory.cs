using System;

namespace Domain.Models.Factories
{
    public class SprintConcreteFactory : ISprintFactory
    {
        public Sprint Create(string name, DateTime startDate, DateTime endDate, Member scrumMaster)
        {
            return new Sprint(name, startDate, endDate, scrumMaster);
        }
    }
}