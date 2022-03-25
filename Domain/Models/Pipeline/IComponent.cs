using System;
namespace Domain.Models.Pipeline
{
    /// <summary>
    /// Visitor pattern
    /// </summary>
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
