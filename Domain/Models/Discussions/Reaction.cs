using System;
using System.Collections.Generic;

namespace Domain.Models.Discussions
{
    /// <summary>
    /// Compiste pattern
    /// </summary>
    public class Reaction : CompositeDiscussion
    {
        public Reaction(string subject, string comment, Member member) : base(subject, comment, member)
        {
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
