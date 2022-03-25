using System;
namespace Domain.Models.Rapportage
{
    public class Header
    {
        public Header(string header)
        {
            Content = header;
        }

        public string Content { get; }
    }
}
