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

        public override List<CompositeDiscussion>.Enumerator GetCompositions()
        {
            return Reactions.GetEnumerator();
        }

        public override void Add(CompositeDiscussion component)
        {
            if(component.IsComposite())
            {
                throw new InvalidOperationException("Composite components could not be added to discussions");
            }

            Reactions.Add(component);
        }

        public override void Remove(CompositeDiscussion component)
        {
            Reactions.Remove(component);
        }
    }
}
