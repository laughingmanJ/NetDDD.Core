using System;
using System.Threading.Tasks;

namespace NetDDD.Core.Contracts
{
    /// <summary>
    /// Represents an event handler for a specific domain event.
    /// </summary>
    public interface IDomainEventHandler
    {
        /// <summary>
        /// Handler’s name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventType"></param>
        /// <returns>Boolean that indicates that it can handle the event type.</returns>
        bool CanHandle(Type eventType);

        /// <summary>
        /// Handles the Domain event.
        /// </summary>
        /// <param name="event">Domain event.</param>
        /// <returns>Asynchronous task for execution.</returns>
        Task Handle(IDomainEvent @event);
    }
}
