namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public interface IMemberFactory
    {
        Member Create(string name, string email);
    }
}