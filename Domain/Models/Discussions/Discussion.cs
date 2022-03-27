using System;
using System.Collections.Generic;

namespace Domain.Models.Discussions
{
    /// <summary>
    /// Compiste pattern
    /// </summary>
    public class Discussion : CompositeDiscussion
    {
        protected List<CompositeDiscussion> Reactions = new();

        public Discussion(string subject, string comment, Member member) 
            : base(subject, comment, member)
        {
        }

        public override void Add(CompositeDiscussion component)
        {
            Reactions.Add(component);
        }

        public override void Remove(CompositeDiscussion component)
        {
            Reactions.Remove(component);
        }
    }
}
