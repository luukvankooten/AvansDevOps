using Domain.Models.Factories;

namespace Domain.Models.Creators
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class ItemConcreteFactory : IItemFactory
    {
        public Item Create(Member developer, string description, Sprint sprint)
        {
            return new Item(developer, description, sprint);
        }
    }
}