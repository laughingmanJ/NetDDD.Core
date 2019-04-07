using NetDDD.Core.Contracts;
using System;
using System.Threading.Tasks;

namespace NetDDD.Core.Bases
{
    public abstract class DomainEventHandler<T> : IDomainEventHandler
        where T : IDomainEvent
    {
        public string Name { get; private set; }

        protected DomainEventHandler(string name)
        {
            Name = name;
        }

        public bool CanHandle(Type eventType )
        {
            return eventType == typeof(T);
        }

        public async Task Handle(IDomainEvent @event)
        {
            var castedEvent = (T)@event;
            await Handle(castedEvent);
        }

        /// <summary>
        /// Handles the specific domain event asynchronously.
        /// </summary>
        /// <param name="event">Domain event.</param>
        /// <returns>Task to run the operation asynchronously.</returns>
        public abstract Task Handle(T @event);
    }
}
