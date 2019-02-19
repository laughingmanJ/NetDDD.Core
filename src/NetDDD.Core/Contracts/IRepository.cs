using System.Collections.Generic;

namespace NetDDD.Core.Contracts
{
    /// <summary>
    /// Represents a domain repository for a specific aggregate.
    /// </summary>
    /// <typeparam name="T">Aggregate type.</typeparam>
    /// <typeparam name="TId">Identity type for the aggregate.</typeparam>
    public interface IRepository<T, TId>
        where T : IAggregateRoot<TId>
    {
        /// <summary>
        /// Finds and returns a aggregate by its specific Id.
        /// </summary>
        /// <param name="id">Identifier for the aggregate.</param>
        /// <returns>If found, it returns the aggregate.</returns>
        T FindById(TId id);

        /// <summary>
        /// Returns all the aggregates in the repository.
        /// </summary>
        /// <returns>Collection of aggregates.</returns>
        IEnumerable<T> FindAll();

        /// <summary>
        /// Returns all count of all the aggregates in the repository.
        /// </summary>
        /// <returns>Count of all the aggregates.</returns>
        long Count();

        /// <summary>
        /// Adds the aggregate by its root to the repository.
        /// </summary>
        /// <param name="entity">The aggregate root.</param>
        /// <returns></returns>
        T Add(T entity);

        /// <summary>
        /// Removes the aggregate by its root to the repository.
        /// </summary>
        /// <param name="entity">The aggregate root.</param>
        void Delete(T entity);
    }
}
