using System.Collections.Generic;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public interface IProjectFactory
    {
        Project Create(Member productOwner);
    }
}