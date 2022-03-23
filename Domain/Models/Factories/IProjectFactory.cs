using System.Collections.Generic;

namespace Domain.Models.Factories
{
    public interface IProjectFactory
    {
        Project Create(IList<Sprint> sprints, Member productOwner);
    }
}