using System.Collections.Generic;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class ProjectConcreteFactory : IProjectFactory
    {
        public virtual Project Create(IList<Sprint> sprints, Member productOwner)
        {
            return new Project(sprints, productOwner);
        }
    }
}