namespace Domain.Models.Factories
{
    public class MemberConcreteFactory : IMemberFactory
    {
        public Member Create(string name, string email)
        {
            return new Member(name, email);
        }
    }
}