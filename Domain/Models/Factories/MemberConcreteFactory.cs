namespace Domain.Models.Factories
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public class MemberConcreteFactory : IMemberFactory
    {
        public Member Create(string name, string email)
        {
            return new Member(name, email);
        }
    }
}