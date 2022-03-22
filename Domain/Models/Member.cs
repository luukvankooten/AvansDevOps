using System;
namespace Domain.Models
{
    public class Member
    {
        public Member(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
