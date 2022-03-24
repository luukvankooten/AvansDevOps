namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public interface IItemFactory
    {
        Item Create(Member developer, string description, Sprint sprint);
    }
}