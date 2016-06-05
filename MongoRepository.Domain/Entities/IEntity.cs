namespace MongoRepository.Domain.Entities
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }

    public interface IEntity : IEntity<string>
    {
    }
}
