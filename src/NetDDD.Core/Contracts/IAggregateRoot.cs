
namespace NetDDD.Core.Contracts
{
    /// <summary>
    /// Represents the root entity of a domain aggregate.
    /// </summary>
    /// <typeparam name="TId">Unique identifier of the entity.</typeparam>
    public interface IAggregateRoot<TId> : IEntity<TId>
    {
    }
}
