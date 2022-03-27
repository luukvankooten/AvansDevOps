using System;
using System.Collections.Generic;

namespace Domain.Models.Discussions
{
    /// <summary>
    /// Compiste pattern
    /// </summary>
    public abstract class CompositeDiscussion
    {

        public string Subject { get; set; }

        public string Comment { get; set; }

        public Member Member { get; set; }

        public CompositeDiscussion(string subject, string comment, Member member)
        {
            Subject = subject;
            Comment = comment;
            Member = member;
        }

        public virtual List<CompositeDiscussion>.Enumerator GetCompositions()
        {
            return new List<CompositeDiscussion>().GetEnumerator();
        }

        public virtual void Add(CompositeDiscussion component)
        {
        }

        public virtual void Remove(CompositeDiscussion component)
        {
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
