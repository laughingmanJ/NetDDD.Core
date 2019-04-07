using NetDDD.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetDDD.Core.Dispatcher
{
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly IEventHandlerProvider _provider;

        public DomainEventDispatcher(IEventHandlerProvider provider)
        {
            if(provider == null)
            {
                throw new ArgumentNullException("provider");
            }

            _provider = provider;
        }

        public async Task Raise(IDomainEvent @event)
        {
            var handlers = _provider.GetHandlers(@event.GetType());

            foreach (var handler in handlers)
            {
                await handler.Handle(@event);
            }
        }

        public async Task Raise(IEnumerable<IDomainEvent> events)
        {
            foreach (var @event in events)
            {
                await Raise(@event);
            }
        }
    }
}
