using Domain.Models.Factories;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class ItemConcreteFactory : IItemFactory
    {
        public virtual Item Create(Member developer, string description, Sprint sprint)
        {
            return new Item(developer, description, sprint);
        }
    }
}