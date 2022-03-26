using System;
using System.Collections.Generic;

namespace Domain.Models.Discussions
{
    /// <summary>
    /// Compiste pattern
    /// </summary>
    public class ThreadDiscussion
    {
        private List<Discussion> Discussoins { get; } = new();

        public bool IsClosed { get; set; }

        public ThreadDiscussion(Item item)
        {
            Item = item;
        }

        //Daar kunnen verschillende discussies met diverse onderwerpen gestart worden of men kan reacties toevoegen
        public Item Item { get; }

        public void AddDiscussion(Discussion discussion)
        {
            if(IsClosed)
            {
                throw new InvalidOperationException("Discussion is close");
            }

            Discussoins.Add(discussion);
        }

        public bool HasDiscussion(Discussion discussion)
        {
            return this.Discussoins.Contains(discussion);
        }
    }
}
