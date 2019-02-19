using System.Collections.Generic;

namespace NetDDD.Core.Contracts
{
    /// <summary>
    /// Represents a domain entity.
    /// </summary>
    /// <typeparam name="TId">Unique identifier of the entity.</typeparam>
    public interface IEntity<TId>
    {
        /// <summary>
        /// Gets the identity of the entity.
        /// </summary>
        TId Id { get; }

        /// <summary>
        /// Gets the domain events within the entity.
        /// </summary>
        /// <returns>A collection of domain events.</returns>
        IEnumerable<IDomainEvent> GetDomainEvents();
    }

}
