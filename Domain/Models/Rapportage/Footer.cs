using System;
namespace Domain.Models.Rapportage
{
    public class Footer
    {
        public Footer(string footer)
        {
            Content = footer;
        }

        public string Content { get; }
    }
}
