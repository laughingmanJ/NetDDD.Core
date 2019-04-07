using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetDDD.Core.Contracts
{
    /// <summary>
    /// Represents a domain event dispatcher for notifying registered event handlers.
    /// </summary>
    public interface IDomainEventDispatcher
    {
        Task Raise(IDomainEvent @event);

        Task Raise(IEnumerable<IDomainEvent> events);
    }
}
