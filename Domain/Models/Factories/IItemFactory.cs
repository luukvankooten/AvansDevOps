namespace Domain.Models.Factories
{
    public interface IItemFactory
    {
        Item Create(Member developer, string description, Sprint sprint);
    }
}