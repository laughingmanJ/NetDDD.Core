using NetDDD.Core.Bases;
using System.Threading.Tasks;

namespace NetDDD.Core.Contracts
{
    /// <summary>
    /// Represents a handler for a specific domain event type.
    /// </summary>
    /// <typeparam name="T">A specific domain event type.</typeparam>
    public interface IDomainEventHandler<T> : IDomainEventHandler
        where T : IDomainEvent
    {
        /// <summary>
        /// Handles the specific domain event asynchronously.
        /// </summary>
        /// <param name="event">Domain event.</param>
        /// <returns>Task to run the operation asynchronously.</returns>
        Task Handle(T @event);
    }
}
