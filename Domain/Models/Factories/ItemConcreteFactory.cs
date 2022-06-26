using Domain.Models.Factories;

namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class ItemConcreteFactory : IItemFactory
    {
        public virtual Item Create(Member developer, Member tester, string description, Sprint sprint)
        {
            return new Item(developer, tester, description, sprint);
        }
    }
}