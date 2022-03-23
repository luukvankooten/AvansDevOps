using System.Collections.Generic;

namespace Domain.Models.Factories
{
    public class ProjectConcreteFactory : IProjectFactory
    {
        public Project Create(IList<Sprint> sprints, Member productOwner)
        {
            return new Project(sprints, productOwner);
        }
    }
}