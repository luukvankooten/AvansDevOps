namespace Domain.Models.Factories
{
    public interface IFactory<T>
    {
        T Create();
    }
}