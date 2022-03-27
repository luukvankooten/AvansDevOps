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

        public override List<CompositeDiscussoin>.Enumerator GetCompistions()
        {
            return Reactions.GetEnumerator();
        }

        public override void Add(CompositeDiscussoin component)
        {
            if(component.IsComposite())
            {
                throw new InvalidOperationException("Composite components could not be added to discussions");
            }

            Reactions.Add(component);
        }

        public override void Remove(CompositeDiscussoin component)
        {
            Reactions.Remove(component);
        }
    }
}
