using System;
using System.Collections.Generic;
using System.Text;

namespace NetDDD.Core.Contracts
{
    public interface IEventHandlerProvider
    {
        IDomainEventHandler GetHandler(string name);

        IEnumerable<IDomainEventHandler> GetHandlers(Type eventType);
    }
}
