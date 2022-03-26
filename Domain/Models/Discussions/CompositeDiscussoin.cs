using System;
namespace Domain.Models.Discussions
{
    /// <summary>
    /// Compiste pattern
    /// </summary>
    public abstract class CompositeDiscussoin
    {

        public string Subject { get; set; }

        public string Comment { get; set; }

        public Member Member { get; set; }

        public CompositeDiscussoin(string subject, string comment, Member member)
        {
            Subject = subject;
            Comment = comment;
            Member = member;
        }

        public virtual void Add(CompositeDiscussoin component)
        {
        }

        public virtual void Remove(CompositeDiscussoin component)
        {
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
