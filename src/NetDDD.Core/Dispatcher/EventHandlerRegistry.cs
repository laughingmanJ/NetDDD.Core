using NetDDD.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetDDD.Core.Dispatcher
{
    public class EventHandlerRegistry
    {
        private readonly IDictionary<string, IDomainEventHandler> _handlers
            = new Dictionary<string, IDomainEventHandler>();
    }
}
