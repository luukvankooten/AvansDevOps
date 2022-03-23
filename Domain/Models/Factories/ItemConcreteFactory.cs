using Domain.Models.Factories;

namespace Domain.Models.Creators
{
    public class ItemConcreteFactory : IItemFactory
    {
        public Item Create(Member developer, string description, Sprint sprint)
        {
            return new Item(developer, description, sprint);
        }
    }
}