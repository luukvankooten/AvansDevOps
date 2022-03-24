using System;
namespace Domain.Models.Pipeline
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
