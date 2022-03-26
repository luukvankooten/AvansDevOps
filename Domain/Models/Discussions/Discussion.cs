using System;
using System.Collections.Generic;

namespace Domain.Models.Discussions
{
    /// <summary>
    /// Compiste pattern
    /// </summary>
    public class Discussion: CompositeDiscussoin
    {
        protected List<CompositeDiscussoin> Reactions = new();

        public Discussion(string subject, string comment, Member member) : base(subject, comment, member)
        {
        }

        public override void Add(CompositeDiscussoin component)
        {
            Reactions.Add(component);
        }

        public override void Remove(CompositeDiscussoin component)
        {
            Reactions.Remove(component);
        }
    }
}
