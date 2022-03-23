using System;

namespace Domain.Models.Factories
{
    public interface ISprintFactory
    {
        Sprint Create(string name, DateTime startDate, DateTime endDate, Member scrumMaster);
    }
}