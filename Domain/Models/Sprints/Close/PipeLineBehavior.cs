using System;
using System.Collections.Generic;
using Domain.Models.Pipeline;

namespace Domain.Models.Sprints.Close
{
    public class PipeLineBehavior: ICloseBehavior
    {
        public PipeLineBehavior(IList<IComponent> components, IVisitor visitor)
        {
            Components = components;
            Visitor = visitor;
        }

        public IList<IComponent> Components { get; }
        public IVisitor Visitor { get; }

        public void Close(Sprint sprint)
        {
            foreach(IComponent component in Components)
            {
                component.Accept(Visitor);
            }
        }
    }
}
