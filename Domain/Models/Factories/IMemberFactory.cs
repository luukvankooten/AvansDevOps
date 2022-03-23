namespace Domain.Models.Factories
{
    public interface IMemberFactory
    {
        Member Create(string name, string email);
    }
}