using NetDDD.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetDDD.Core.Dispatcher
{
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private IDictionary<string, IDomainEventHandler> _handlers = new Dictionary<string, IDomainEventHandler>();

        public async Task Raise<T>(T @event)
            where T : IDomainEvent
        {
            if (@event == null)
            {
                throw new ArgumentNullException("@event", "Domain event cannot be null.");
            }

            var handlers = _handlers
                .OfType<IDomainEventHandler<T>>();

            foreach (var handler in handlers)
            {
                await handler.Handle(@event);
            }
        }

        public void Register(IDomainEventHandler handler)
        {
            ValidateHandler(handler);

            if(_handlers.ContainsKey(handler.Name))
            {
                throw new ArgumentException("Handler is already registered and cannot be registered again.", "handler");
            }

            _handlers.Add(handler.Name, handler);
        }

        public void Unregister(IDomainEventHandler handler)
        {
            ValidateHandler(handler);

            if(!_handlers.ContainsKey(handler.Name))
            {
                throw new ArgumentException("Unable to remove handler because it is not registered.", "handler");
            }

            _handlers.Remove(handler.Name);
        }

        public bool IsRegistered(string handlerName)
        {
            return _handlers.ContainsKey(handlerName);
        }

        public bool IsRegistered(IDomainEventHandler handler)
        {
            ValidateHandler(handler);
            return IsRegistered(handler.Name);
        }

        private void ValidateHandler(IDomainEventHandler handler)
        {
            if (handler == null)
            {
                throw new ArgumentNullException("handler", "Handler cannot be null.");
            }

            if (string.IsNullOrEmpty(handler.Name))
            {
                throw new NullReferenceException("Handler name cannot be null or empty.");
            }
        }
    }
}
